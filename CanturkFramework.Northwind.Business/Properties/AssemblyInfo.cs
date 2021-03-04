using System.IO;using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CanturkFramework.Core.Aspects.Postsharp.ExceptionAspects;
using CanturkFramework.Core.Aspects.Postsharp.LogAspects;
using CanturkFramework.Core.Aspects.Postsharp.PerformanceAspects;
using CanturkFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CanturkFramework.Northwind.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("CanturkFramework.Northwind.Business")]
[assembly: AssemblyCopyright("Copyright ©  2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: LogAspect(typeof(DatabaseLogger),AttributeTargetTypes = "CanturkFramework.Northwind.Business.Concrete.Managers.*")] //Get* getle başlayan *add* içinde add geçen.
[assembly: ExceptionLogAspect(typeof(DatabaseLogger),AttributeTargetTypes = "CanturkFramework.Northwind.Business.Concrete.Managers.*")] //Get* getle başlayan *add* içinde add geçen.
[assembly: PerformanceCounterAspect(AttributeTargetTypes = "CanturkFramework.Northwind.Business.Concrete.Managers.*")] 

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7c1eb1a0-dfda-4d07-9986-694236f24fb9")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
