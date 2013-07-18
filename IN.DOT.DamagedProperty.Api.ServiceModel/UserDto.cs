using System;
using System.Runtime.Serialization;
using IN.DOT.DamagedProperty.Api.Persistence.Abstract;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

namespace IN.DOT.DamagedProperty.Api.ServiceModel
{
    [DataContract]
    [Serializable]
   public class UserDto : DtoBase, IHasId<Guid > 
    {
        



        // [AutoIncrement] // Creates Auto primary key
        [DataMember]
      //  public Guid ID { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string PasswortdHash { get; set; }

        [DataMember]
        [Index(Unique = true)] // Creates Unique Index
        public string Email { get; set; }

        public Guid Id
        {
            get { return Guid.NewGuid(); }
        }
        /// <summary>
        ///  Constructor
        /// No parameters and all types are intialized to their
        /// null values as defined in CommonBase.
        /// </summary>
        public UserDto()
        {

            ID = GuidNullValue;
            UserName = StringNullValue;
            Password = StringNullValue;
            PasswortdHash = StringNullValue;
            Email = StringNullValue;

            if (ID == Guid.Empty) ID = Guid.NewGuid();
        
        }

        //public UserDto(string userName,string password, string email,string passwordHash,bool IsActive )
        //{
        //    UserName = userName;
        //    Password = password;
        //    passwordHash = passwordHash;
        //    Email = email;
        //}
   }
}
