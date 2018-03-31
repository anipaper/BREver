using System;

namespace BREver
{
    public struct ItemType
    {
        private readonly int id;
        private readonly int parent;

        public ItemType(int id)
            : this(id, None)
        {

        }

        public ItemType(int id, ItemType parent)
        {
            this.id = id;
            this.parent = parent.id;
        }

        public int Id
        {
            get { return this.id; }
        }

        public ItemType Parent
        {
            get
            {
                return this.parent != None.id
                    ? ItemTypes.GetItemType(this.parent)
                    : None;
            }
        }

        public static ItemType None
        {
            get { return new ItemType(0); }
        }
    }
}