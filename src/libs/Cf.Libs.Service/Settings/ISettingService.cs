using Cf.Libs.Core.Enums;
using Cf.Libs.Core.Infrastructure.Service;

namespace Cf.Libs.Service.Settings
{
    public interface ISettingService : IBaseService
    {
        T Get<T>(string settingKey) where T : class, new();
        bool Save<T>(string key, T model) where T : class, new();
        string[] Get(string settingKey);
        bool Save(string key, string[] model);
        bool Delete(string settingKey);
        bool Remove(int id);
    }
}