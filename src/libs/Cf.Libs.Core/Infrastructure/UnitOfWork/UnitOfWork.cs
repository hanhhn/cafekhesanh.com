using Cf.Libs.Core.Exeptions;
using Cf.Libs.Core.Infrastructure.Context;
using Cf.Libs.Core.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Cf.Libs.Core.Infrastructure.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork, IDisposable
         where TContext : DbContext
    {
        private readonly DbContext _context;
		private readonly IIdentityContext _identity;

		public UnitOfWork(TContext context, IIdentityContext identity)
        {
            _context = context;
			_identity = identity;
		}

        public int SaveChanges()
        {
            _context.ChangeTracker.DetectChanges();
            if (_context.ChangeTracker.HasChanges())
            {
                foreach (var dbEntity in _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified))
                {
                    IChangeableEntity entity = dbEntity.Entity as IChangeableEntity;
                    if (entity == null)
                        continue;

					var logged = _identity.LoggedUser() ?? "system";
					if (dbEntity.State == EntityState.Added)
                    {
                        entity.Default(true, logged);
                        continue;
                    }

                    if (dbEntity.State == EntityState.Modified)
                    {
                        entity.Default(false, logged);
                    }
                }
            }

            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new InformationException("Unable to update or delete. The record modified by another user. Try again!");
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}