using System;
using System.Collections.Generic;

namespace BREver
{
    public class AttributeTable
    {
        private readonly Dictionary<AttributeType, double> attributes;

        public AttributeTable()
        {
            this.attributes = new Dictionary<AttributeType, double>();
        }

        public double GetAttribute(AttributeType attribute)
        {
            if (!this.attributes.ContainsKey(attribute))
                return 0;

            return this.attributes[attribute];
        }

        public void SetAttribute(AttributeType attribute, double value)
        {
            this.attributes[attribute] = value;
        }

        public AttributeTable Clone()
        {
            var clone = new AttributeTable();
            foreach (var attribute in this.attributes)
            {
                clone.SetAttribute(attribute.Key, attribute.Value);
            }

            return  clone;

        }
    }
}