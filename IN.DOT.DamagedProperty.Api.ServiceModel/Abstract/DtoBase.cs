using IN.DOT.DamagedProperty.Api.Domain.Model;  
namespace IN.DOT.DamagedProperty.Api.Persistence.Abstract
{
    /// <summary>
    ///  IsNew flag that can be used to indicate if a DTO contains 
    /// newly created data (as opposed to data that was pulled from the database).
    /// </summary>
    public abstract class DtoBase : CommonBase
    {
        public bool IsNew { get; set; }
    }
}
