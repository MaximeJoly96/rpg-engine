using UnityEngine;

namespace RPG_Engine.System
{
    public class CursorManager : MonoBehaviour, ICreator
    {
        #pragma warning disable 0649
        [SerializeField]
        private GameObject _playerCursor;
        [SerializeField]
        private GameObject _uiCanvas;
        #pragma warning restore 0649

        public GameObject Cursor { get { return _playerCursor; } }

        void Awake()
        {
            CreateObject(_playerCursor);
        }

        public GameObject CreateObject(GameObject obj)
        {
            return Instantiate(obj, _uiCanvas.transform);
        }
    }
}

