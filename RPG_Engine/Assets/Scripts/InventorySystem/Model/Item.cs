using RPG_Engine.InventorySystem.Interfaces;

namespace RPG_Engine.InventorySystem.Model
{
    public abstract class Item : IPurchasable
    {
        private int _id;
        private string _name;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        protected Item(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public abstract void Buy();
        public abstract void Sell();

        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}

