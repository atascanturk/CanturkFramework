using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CanturkFramework.Core.CrossCuttingConcerns.Logging.Log4Net;
using log4net;
using PostSharp.Aspects;

namespace CanturkFramework.Core.Aspects.Postsharp.ExceptionAspects
{
    [Serializable]
    public class ExceptionLogAspect : OnExceptionAspect
    {
        private Type _loggerType;
        private LoggerService _loggerService;

        public ExceptionLogAspect(Type loggerType)
        {
            _loggerType = loggerType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (_loggerType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong logger type");
            }
            _loggerService = (LoggerService)Activator.CreateInstance(_loggerType);
            base.RuntimeInitialize(method);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            if (_loggerType != null)
            {
                _loggerService.Error(args.Exception);
            }
            
        }
    }
}
