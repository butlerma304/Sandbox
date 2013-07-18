using System;
using ServiceStack.DataAnnotations;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
       [FluentValidation.Attributes.Validator(typeof(CreditCardValidator))]
    [Serializable]
    public class CreditCard : EntityBase
    {
        [AutoIncrement] // Creates Auto primary key
        public int Id { get; set; }
        public string CreditCardType { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpDate { get; set; }
        public string CvvCode { get; set; }

        public CreditCard(){}
        public CreditCard(string cardType, string cardNumber, string cardExpirationDate,string cvvCode)
        {
            CreditCardType = cardType;
            CreditCardNumber = cardNumber;
            CreditCardExpDate = cardExpirationDate;
            CvvCode = cvvCode;
        }

        #region Credit CardCard Validation
      
        public class CreditCardValidator : AbstractValidator<CreditCard>
        {
            public CreditCardValidator()
            {
                RuleFor(x => x.CreditCardType ).NotEmpty().Length(2, 10).WithMessage("CreditCard Type selection is required");
                RuleFor(x => x.CreditCardNumber ).NotEmpty().Length(2, 10).WithMessage("Valid CreditCard Number is required");
                RuleFor(x => x.CreditCardExpDate ).NotEmpty().Length(2, 10).WithMessage("CreditCard Expiration date is required");
                RuleFor(x => x.CvvCode).NotEmpty().Length(2, 10).WithMessage("CreditCard CVV is required");
            }
        }
        #endregion
    }
}
