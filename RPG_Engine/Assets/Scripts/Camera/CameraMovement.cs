using UnityEngine;
using RPG_Engine.Movement;

namespace RPG_Engine.Camera
{
    public class CameraMovement : MonoBehaviour
    {
        private const float SPEED = 5.0f;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Z))
                transform.position += Vector3.forward * Time.deltaTime * SPEED;

            if (Input.GetKey(KeyCode.Q))
                transform.position += Vector3.left * Time.deltaTime * SPEED;

            if (Input.GetKey(KeyCode.S))
                transform.position += Vector3.back * Time.deltaTime * SPEED;

            if (Input.GetKey(KeyCode.D))
                transform.position += Vector3.right * Time.deltaTime * SPEED;
        }
    }
}
