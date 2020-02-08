using UnityEngine;
using RPG_Engine.InventorySystem.Tools;

namespace RPG_Engine.InventorySystem.Managers
{
    public class ItemManager : MonoBehaviour
    {
        void Start()
        {
            ItemFileReader fileReader = new ItemFileReader();
            Debug.Log(fileReader.ReadItemData("Item_0"));
        }
    }
}

