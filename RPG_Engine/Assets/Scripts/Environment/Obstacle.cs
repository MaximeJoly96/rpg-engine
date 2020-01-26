using UnityEngine;

namespace RPG_Engine.Environment
{
    public class Obstacle : MonoBehaviour
    {
        public Collider ObstacleCollider
        {
            get
            {
                return GetComponent<Collider>();
            }
        }

        public Vector3 Position
        {
            get
            {
                if (ObstacleCollider)
                {
                    return ObstacleCollider.bounds.center;
                }
                else
                    throw new MissingComponentException("There is no Collider on this Obstacle to define its size.");
            }
        }

        public Vector3 Size
        {
            get
            {
                if (ObstacleCollider)
                {
                    return ObstacleCollider.bounds.size;
                }
                else
                    throw new MissingComponentException("There is no Collider on this Obstacle to define its size.");
            }
        }
        


    }
}
