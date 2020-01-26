using UnityEngine;

namespace RPG_Engine.Environment
{
    public class GridCell
    {
        private readonly Vector3 _position;
        private readonly bool _isObstacle;

        public Vector3 Position { get { return _position; } }
        public bool IsObstacle { get { return _isObstacle; } }

        public GridCell(Vector3 position, bool isObstacle)
        {
            _position = position;
            _isObstacle = isObstacle;
        }
    }
}
