using System;

namespace BREver
{
    public struct AttributeModifier
    {
        private readonly AttributeType attribute;
        private readonly double percentage;
        private readonly double value;

        public AttributeModifier(AttributeType attribute, double percentage, double value)
        {
            this.attribute = attribute;
            this.percentage = percentage;
            this.value = value;
        }

        public AttributeType Attribute
        {
            get { return this.attribute; }
        }

        public double Percentage
        {
            get { return this.percentage; }
        }

        public double Value
        {
            get { return this.value; }
        }
    }
}