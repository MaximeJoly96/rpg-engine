using UnityEngine;

namespace RPG_Engine.System
{
    public interface ICreator
    {
        GameObject CreateObject(GameObject obj);
    }
}