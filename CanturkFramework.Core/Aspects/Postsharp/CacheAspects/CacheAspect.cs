using CanturkFramework.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CanturkFramework.Core.Aspects.Postsharp.CacheAspects
{

    [Serializable]
    public class CacheAspect :MethodInterceptionAspect
    {
        Type _cacheType;
        int _cacheByMinute;
        ICacheManager _cacheManager;

        public CacheAspect(Type cacheType, int cacheByMinute=60)
        {
            _cacheByMinute = cacheByMinute;
            _cacheType = cacheType;
        }

        public override void RuntimeInitialize(MethodBase method) // postsharp initialize methodu.
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false) 
            {
                throw new Exception("Wrong Cache Manager");
            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0}.{1}.{2}", 
                args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name,
                args.Method.Name);

            var arguments = args.Arguments.ToList();

            var key = string.Format("{0}({1})", methodName,
                string.Join(",", arguments.Select(x => x != null ? x.ToString() : "<Null>")));

            if (_cacheManager.IsAdd(key)) 
            {
                args.ReturnValue = _cacheManager.Get<object>(key);
            }
            base.OnInvoke(args);
            _cacheManager.Add(key, args.ReturnValue, _cacheByMinute);
        }
    }
}
