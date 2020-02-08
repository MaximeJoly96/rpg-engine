using System.Xml;
using RPG_Engine.InventorySystem.Model;
using UnityEngine;

namespace RPG_Engine.InventorySystem.Tools
{
    public class ItemFileReader
    {
        public Item ReadItemData(string fileName)
        {
            XmlDocument document = new XmlDocument();
            document.Load(Application.dataPath + "/Data/InventorySystem/Items/" + fileName + ".xml");

            XmlNodeList nodeList = document.GetElementsByTagName("ItemData");
            if (nodeList.Count > 0)
            {
                XmlNode node = nodeList[0];
                XmlNode namesNode = node.SelectSingleNode("Names");

                if (namesNode != null)
                {
                    XmlNodeList names = namesNode.SelectNodes("Name");
                    string nameAttribute = "";
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].Attributes["Language"].InnerText.Equals("en-GB"))
                            nameAttribute = names[i].Attributes["Value"].InnerText;
                    }

                    return new Consumable(int.Parse(node.SelectSingleNode("Id").Attributes["Value"].InnerText),
                                          nameAttribute);
                }
                else
                    throw new XmlException("Could not read property of item " + fileName + ".");
            }
            else
                throw new XmlException("Could not read property of item " + fileName + ".");
        }
    }
}
