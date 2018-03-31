using System;
using System.Collections.Generic;

namespace BREver
{
    public static class ItemTypes
    {
        private static readonly Dictionary<int, Entry> types;

        static ItemTypes()
        {
            types = new Dictionary<int, Entry>();
        }

        public static ItemType CreateItemType(int id, ItemType parent, string name)
        {
            var itemType = new ItemType(id, parent);
            var entry = new Entry(itemType, name);

            types.Add(id, entry);
            return itemType;
        }

        public static ItemType GetItemType(int id)
        {
            return types[id].Type;
        }

        public static string GetItemTypeName(int id)
        {
            return types[id].Name;
        }

        public static string GetItemTypeName(ItemType type)
        {
            return GetItemTypeName(type.Id);
        }

        private struct Entry
        {
            private readonly ItemType type;
            private readonly string name;

            public Entry(ItemType type, string name)
            {
                if (name is null)
                    throw new ArgumentNullException(nameof(name));

                this.type = type;
                this.name = name;
            }

            public ItemType Type
            {
                get { return this.type; }
            }

            public string Name
            {
                get { return this.name; }
            }
        }
    }
}