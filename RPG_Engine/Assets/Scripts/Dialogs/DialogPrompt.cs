using UnityEngine;
using UnityEngine.UI;

namespace RPG_Engine.Dialogs
{
    public class DialogPrompt : MonoBehaviour
    {
        public void SetText(string text)
        {
            GetComponentInChildren<Text>().text = text;
        }

    }
}
