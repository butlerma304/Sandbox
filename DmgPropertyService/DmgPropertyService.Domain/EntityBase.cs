﻿using System;
using System.Runtime.Serialization;
using DmgPropertyService.Domain.Attributes;


namespace DmgPropertyService.Domain
{
    [Serializable, DataContract]
    public class EntityBase  
    {
        
        public EntityBase()
        {
            LastModifiedDate = CreateDate = DateTime.Now;
        }

        [DataMember]
        public virtual Guid? ID { get; set; }

        [ColumnName("CreateBy")]
        public User CreateBy { get; set; }

        public DateTime? CreateDate { get; set;}

        [ColumnName("Last Modified Date")]
        public DateTime? LastModifiedDate { get; set; }

        [ColumnName("Last Modified By")]
        public User LastModifiedBy { get; set; }

    }
}