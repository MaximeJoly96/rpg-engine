using UnityEngine;

namespace RPG_Engine.Movement
{
    public class PlayerController : MonoBehaviour
    {
        private static float SPEED
        {
            get { return 3.0f * Time.deltaTime; }
        }

        private Vector3 _directionVector;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Z))
            {
                _directionVector = 
            }
                transform.Translate(Vector3.forward * SPEED);

            if (Input.GetKey(KeyCode.Q))
                transform.Translate(Vector3.left * SPEED);

            if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * SPEED);

            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right * SPEED);
        }
    }
}
