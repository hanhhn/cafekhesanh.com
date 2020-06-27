﻿using Coffee.Libs.Core;

namespace Coffee.Libs.Infrastructure
{
	public class EngineContext
	{
		public static IEngine Create()
		{
			return Singleton<IEngine>.Instance ?? (Singleton<IEngine>.Instance = new CoffeeEngine());
		}

		public static IEngine Current
		{
			get
			{
				if (Singleton<IEngine>.Instance == null)
				{
					Create();
				}

				return Singleton<IEngine>.Instance;
			}
		}
	}
}