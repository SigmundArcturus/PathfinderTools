using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pathfinder.Generators.Background
{
    internal static class TableHelper
    {
        public static List<TProvider> GetProviderList<TProvider>()
            where TProvider : class
        {
            List<TProvider> providers = new List<TProvider>();

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsClass && !type.IsAbstract && typeof(TProvider).IsAssignableFrom(type))
                {
                    providers.Add(Activator.CreateInstance(type) as TProvider);
                }
            }

            return providers;
        }
    }
}
