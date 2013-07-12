using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using ServiceStack.FluentValidation;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.Validation;

namespace IN.DOT.DamagedProperty.Api.WebUI.Infrastructure.Container
{
    internal class ValidationModule
    {
        internal static void Configure(Funq.Container container)
        {
            // We could move this to the config file or just loop through all executing assemblies.
            string[] assemblyNameList = { "IN.DOT.DamagedProperty.Api.ServiceModel", "IN.DOT.DamagedProperty.Api.Domain" };

            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => assemblyNameList.Contains(assembly.GetName().Name)))
            {
                container.RegisterValidators(assembly);

                // If we find that we need to set the validator with code, then we can add a marker attribute,
                // AutoBindValidatorAttribute, to designate the model objects that we want to omit from the 
                // auto-registration process.
                //AssemblyScanner.FindValidatorsInAssembly(assembly)
                //    .ForEach(match =>
                //    {
                //        // Grab the AutoBindValidatorAttribute from the validator class.
                //        var autoBind = match.ValidatorType.GetCustomAttributes(typeof(AutoBindValidatorAttribute), true).FirstOrDefault();
                //        // AutoBind defaults to true. So if the AutoBindValidatorAttribute is not present or
                //        // if it is present and turned on, then we will wire up the dependency injection.
                //        if (autoBind == null || ((AutoBindValidatorAttribute)autoBind).AutoBind == true)
                //            container.RegisterAutoWiredType(match.ValidatorType, match.InterfaceType);
                //    });
            }
        }
    }
}