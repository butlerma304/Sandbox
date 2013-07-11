using System;
using System.Runtime.Serialization;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmgPropertyService.Domain
{
    [Serializable, DataContract]
    public class EntityBase
    {
        public EntityBase()
        {
            LastModifiedDate = CreateDate = DateTime.Now;
        }

        public virtual Guid? ID { get; set; }
        public User CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}