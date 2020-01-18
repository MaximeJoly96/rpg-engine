using UnityEngine;
using RPG_Engine.System.Events;

namespace RPG_Engine.Cursor
{
    public class PlayerCursor : MonoBehaviour
    {
        public Vector3Event MovementEvent;

        private void Awake()
        {
            MovementEvent = new Vector3Event();
        }

        private void Update()
        {
            transform.position = Input.mousePosition;

            CheckPlayerClicks();
        }

        private void CheckPlayerClicks()
        {
            if (Input.GetMouseButtonDown(1))
                MovementEvent.Invoke(transform.position);
        }
    }
}

