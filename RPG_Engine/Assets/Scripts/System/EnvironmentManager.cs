using UnityEngine;

namespace RPG_Engine.System
{
    public class EnvironmentManager : MonoBehaviour, ICreator
    {
        #pragma warning disable 0649
        [SerializeField]
        private GameObject _environment;
        #pragma warning restore 0649

        public GameObject Environment { get { return _environment; } }

        void Awake()
        {
            CreateObject(_environment);
        }

        public GameObject CreateObject(GameObject obj)
        {
            return Instantiate(obj);
        }
    }
}
