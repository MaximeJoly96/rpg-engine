using UnityEngine;

namespace RPG_Engine.System
{
    public class PlayerManager : MonoBehaviour, ICreator
    {
        #pragma warning disable 0649
        [SerializeField]
        private GameObject _player;
        #pragma warning restore 0649

        public GameObject Player { get { return _player; } }

        void Awake()
        {
            CreateObject(_player);
        }

        public GameObject CreateObject(GameObject obj)
        {
            return Instantiate(obj);
        }
    }
}
