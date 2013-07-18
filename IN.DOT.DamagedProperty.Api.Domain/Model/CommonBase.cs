using System;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
    /// <summary>
    ///  CommonBase’s only purpose is to contain static properties that define null values
    /// </summary>
   public class CommonBase
    {
    

            // Let's setup standard null values

            public static DateTime DateTimeNullValue = DateTime.MinValue;

            public static Guid GuidNullValue = Guid.Empty;

            public static int IntNullValue = int.MinValue;

            public static float FloatNullValue = float.MinValue;

            public static decimal DecimalNullValue = decimal.MinValue;

            public static string StringNullValue = null;

       
    }
}
