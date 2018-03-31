using System;

namespace BREver
{
    public class Equipment :Item, IAttributeModifier
    {

        private readonly AttributeModifier[] attributeList;
        private int durability;
        private readonly int value;

        public  Equipment(AttributeModifier[] attributeList, int durability, int value, double weight, string name, ItemType type, int maxStackSize )
            : base(weight, name, type, maxStackSize)
        {
            this.attributeList = attributeList;
            this.durability = durability;
            this.value = value;
        }

        public  AttributeModifier[] GetModifiers()
        {
            return  this.attributeList;
        }

        public int GetDurability()
        {
            return this.durability;
        }

        public void ChangeDurability(int newDurability)
        {
            this.durability = newDurability;
        }

        public bool IsBroken()
        {
            return this.durability == 0;
        }

        public override double GetPrice()
        {
            return (this.durability / 100) * this.value;
        }



    }
}