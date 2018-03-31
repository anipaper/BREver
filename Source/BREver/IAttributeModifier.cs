using System;

namespace BREver
{
    public interface IAttributeModifier
    {
        AttributeModifier[] GetModifiers();
    }
}