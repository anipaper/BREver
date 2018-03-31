using System;

namespace BREver
{
    public abstract class Item
    {
        private readonly double weight;
        private readonly string name;
        private readonly ItemType type;
        private readonly int maxStackSize;
        private  readonly int itemId;

        /// <inheritdoc />
        protected Item(double weight, string name, ItemType type, int maxStackSize, int id)
        {
            this.weight = weight;
            this.name = name;
            this.type = type;
            this.maxStackSize = maxStackSize;
            this.itemId = id;
        }

        public abstract double GetPrice();

        public virtual string GetDisplayName()
        {
            return this.name;
        }

        public double Weight
        {
            get { return this.weight; }
        }

        public int MaxStackSize
        {
            get { return this.maxStackSize; }
        }
    }
}