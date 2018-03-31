using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace BREver
{
    public class Character
    {

        private EquipmentSlots[] equipment;
        private AttributeTable baseAttribute;

        public Character(EquipmentSlots[] equipment, AttributeTable baseAttribute)
        {
            this.equipment = equipment;
            this.baseAttribute = this.baseAttribute;
        }

        public EquipmentSlots[] GetEquipment()
        {
            return this.equipment;
        }

        public AttributeTable GetBaseAttribute()
        {
            return this.baseAttribute;
        }

       

        public AttributeTable GetFinalAttribute()
        {
            var FinalAttribute = this.baseAttribute.Clone();
            
            foreach (var item in this.equipment)
            {
                foreach (var modifier in item.GetContent().GetModifiers())
                {
                    double newValue = FinalAttribute.GetAttributeValue(modifier.Attribute) + modifier.Value;
                    FinalAttribute.SetAttribute(modifier.Attribute, newValue);
                }
            }

            foreach (var item in this.equipment)
            {
                foreach (var modifier in item.GetContent().GetModifiers())
                {
                    double newValue = FinalAttribute.GetAttributeValue(modifier.Attribute) + 
                                      (modifier.Percentage / 100) * this.baseAttribute.GetAttributeValue(modifier.Attribute);
                    FinalAttribute.SetAttribute(modifier.Attribute, newValue);
                }
            }

            return FinalAttribute;

        }

    }


    public class EquipmentSlots
    {
        private readonly ItemType itemType;
        private Equipment content;
        public EquipmentSlots(ItemType itemType, Equipment content)
        {
            this.itemType = itemType;
            this.content = content;
        }

        public Equipment GetContent()
        {
            return this.content;
        }

        public  ItemType GetItemType()
        {
            return this.itemType;
        }

        public void SetContent(Equipment newEquipment)
        {
            this.content = newEquipment;
        }
        

    }

/*
 * [0 -> 10, 1 -> 5, 2 -> 4]
 */
}
