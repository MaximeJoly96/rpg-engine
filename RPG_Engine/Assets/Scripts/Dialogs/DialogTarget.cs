using UnityEngine;

namespace RPG_Engine.Dialogs
{
    [RequireComponent(typeof(Collider))]
    public class DialogTarget : MonoBehaviour
    {
        [SerializeField]
        private string _text;

        public string Text { get { return _text; } }
    }
}

