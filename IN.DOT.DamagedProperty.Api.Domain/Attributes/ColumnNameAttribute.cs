using System;

namespace IN.DOT.DamagedProperty.Api.Domain.Attributes
{
    class ColumnNameAttribute:Attribute
    {
        public ColumnNameAttribute (string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
