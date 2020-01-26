using UnityEngine;
using System.Collections;

namespace RPG_Engine.Environment
{
    public class WorldGrid
    {
        private readonly GridCell[,,] _cells;

        public GridCell[,,] Cells { get { return _cells; } }

        public WorldGrid(GridCell[,,] cells)
        {
            _cells = cells;
        }

        public static void CreateWorldGrid(Vector3 size)
        {
            Obstacle[] obstacles = Object.FindObjectsOfType<Obstacle>();
            GridCell[,,] gridCells = new GridCell[(int)size.x, (int)size.y, (int)size.z];

            foreach(Obstacle obs in obstacles)
            {
                gridCells[(int)obs.transform.position.x, (int)obs.transform.position.y, (int)obs.transform.position.z] =
                    new GridCell(obs.transform.position, true);
            }

            WorldGrid worldGrid = new WorldGrid(gridCells);
        }
    }
}
