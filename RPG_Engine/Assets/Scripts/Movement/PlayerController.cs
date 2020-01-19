using RPG_Engine.Cursor;
using UnityEngine;

namespace RPG_Engine.Movement
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerCursor _playerCursor;
        private Plane _plane;

        private void Start()
        {
            _playerCursor = FindObjectOfType<PlayerCursor>();
            _playerCursor.MovementEvent.AddListener(MoveToLocation);

            _plane = new Plane(new Vector3(0.0f, 0.0f, 0.0f),
                               new Vector3(1.0f, 0.0f, 0.0f),
                               new Vector3(0.0f, 0.0f, 1.0f));
        }

        private void MoveToLocation(Vector3 position)
        {
            PlayerMovement pm = GetComponent<PlayerMovement>();
            if (pm)
                pm.StopMovement();

            Ray ray = UnityEngine.Camera.main.ScreenPointToRay(position);
            float distance;
            _plane.Raycast(ray, out distance);
            Vector3 projPosition = ray.GetPoint(distance);

            pm = gameObject.AddComponent<PlayerMovement>();
            pm.Init(transform.position, projPosition);
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.E))
            {

            }
        }
    }
}

