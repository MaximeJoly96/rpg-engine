using UnityEngine;

namespace RPG_Engine.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector3 _endPosition;

        private const float SPEED = 5.0f;
        private const float MIN_DISTANCE_BEFORE_END = 0.02f;

        public void Init(Vector3 startPosition, Vector3 endPosition)
        {
            transform.position = startPosition;
            _endPosition = endPosition;

            transform.LookAt(_endPosition);
        }

        private void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPosition, SPEED * Time.deltaTime);

            if(Vector3.Distance(transform.position, _endPosition) <= MIN_DISTANCE_BEFORE_END)
                Destroy(this);
        }

        public void StopMovement()
        {
            Destroy(this);
        }
    }
}
