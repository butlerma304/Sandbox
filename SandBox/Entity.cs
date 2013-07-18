﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
    [Serializable]
    public abstract class Entity:EntityBase 
    {

        public int Id { get; set; }

    }
}