using System;
using System.Security.Cryptography;
using System.Text;

namespace Coffee.Libs.Common.Extensions
{
	public static class UniqueKeyGenerator
	{
		public static string RNGCharacterMask(bool year = true, int size = 6, bool uperCase = true)
		{
			var chars = "ACDEFGHIJKLMNQRSTUVWXYZ12345679acdefghijklmnqrstuvwxyz".ToCharArray();
			var data = new byte[1];
			var crypto = new RNGCryptoServiceProvider();
			crypto.GetNonZeroBytes(data);
			data = new byte[size];
			crypto.GetNonZeroBytes(data);
			var result = new StringBuilder(size);

			if (year)
				result.Append(DateTime.Now.ToString("yyyy").Substring(2, 2));

			foreach (var b in data)
			{
				result.Append(chars[b % (chars.Length - 1)]);
			}

			if (uperCase)
				return result.ToString().ToUpper();
			return result.ToString();
		}
	}
}
