using System;
using System.Collections.Generic;
using System.Reflection;

namespace ServiceTower.Utils
{
    public interface IReflectionUtil
    {
        IEnumerable<Assembly> GetAssemblies();
        IEnumerable<Type> GetTypes(IEnumerable<Assembly> assemblies);

    }
}