using UnityEngine;

namespace RPG_Engine.InventorySystem.Model
{
    public class Consumable : Item
    {
        public Consumable(int id, string name) : base(id, name) { }

        public override void Buy()
        {
            Debug.Log("Consumable bought");
        }

        public override void Sell()
        {
            Debug.Log("Consumable sold");
        }
    }
}
