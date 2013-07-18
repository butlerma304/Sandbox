using System;
using System.Linq;
using System.Reflection;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.WebUI.Validators;
using ServiceStack.FluentValidation;
using ServiceStack.ServiceInterface.Validation;

namespace IN.DOT.DamagedProperty.WebUI.Infrastructure.Container
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
                container.RegisterValidators(typeof(UserBillingInfoValidator).Assembly);
                container.RegisterValidators(typeof(UserValidator).Assembly);
                container.RegisterValidators(typeof(AddressValidator).Assembly);
                container.RegisterValidators(typeof(UserBillingInfoValidator).Assembly);
             
                
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



    #region User Validation
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().Length(2, 10).WithMessage("UserName is required");
            RuleFor(x => x.Password).NotEmpty().Length(2, 10).WithMessage("Password is required");
            RuleFor(x => x.Email).NotEmpty().Length(10).WithMessage("Email is required");
        }
    }
    #endregion

    #region UserBillingInfo Validation

    public class UserBillingInfoValidator : AbstractValidator<BillingInfo>
    {
        public UserBillingInfoValidator()
        {

            RuleFor(x => x.FirstName).NotEmpty().Length(2, 10).WithMessage("First Name is required");
            RuleFor(x => x.LastName).NotEmpty().Length(2, 10).WithMessage("Last Name is required");
            RuleFor(x => x.EmailAddress).NotEmpty().Length(2, 10).WithMessage("Email Address is required");
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(2, 10).WithMessage("Phone is required");
            //    RuleFor(x => x.Address).NotEmpty().SetValidator(new AddressValidator());


        }
    }
    #endregion

    #region Address Validation
    public class AddressValidator : AbstractValidator<Address>
    {

        public AddressValidator()
        {
            RuleFor(x => x.AddressLine1).NotEmpty().Length(2, 10).WithMessage("Address is required");
            RuleFor(x => x.AddressLine2).Length(0, 10).WithMessage("Address1 is required");
            RuleFor(x => x.City).NotEmpty().Length(2, 10).WithMessage("City is required");
            RuleFor(x => x.State).NotEmpty().Length(2, 10).WithMessage("State Selection is required");
            RuleFor(x => x.ZipCode).NotEmpty().Length(2, 10).WithMessage("Zip Code  is required");
        }

    }
    #endregion
}