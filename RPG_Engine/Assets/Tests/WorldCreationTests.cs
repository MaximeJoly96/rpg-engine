using System.Collections;
using NUnit.Framework;
using UnityEngine;
using RPG_Engine.System;
using UnityEngine.TestTools;

namespace Tests
{
    public class WorldCreationTests
    {
        private PlayerManager _playerManager;
        private EnvironmentManager _envManager;
        private CursorManager _cursorManager;

        [UnityTest]
        public IEnumerator CreateEnvironment()
        {
            yield return new WaitForEndOfFrame();
            _envManager = Object.Instantiate(Resources.Load<EnvironmentManager>("Prefabs/EnvironmentManager"));
            GameObject obj = _envManager.CreateObject(_envManager.Environment);

            Assert.IsNotNull(obj);
        }

        [UnityTest]
        public IEnumerator CreatePlayer()
        {
            yield return new WaitForEndOfFrame();
            _playerManager = Object.Instantiate(Resources.Load<PlayerManager>("Prefabs/PlayerManager"));
            GameObject obj = _playerManager.CreateObject(_playerManager.Player);

            Assert.IsNotNull(obj);
        }

        [UnityTest]
        public IEnumerator CreateCursor()
        {
            yield return new WaitForEndOfFrame();
            _cursorManager = Object.Instantiate(Resources.Load<CursorManager>("Prefabs/CursorManager"));
            GameObject obj = _cursorManager.CreateObject(_cursorManager.Cursor);

            Assert.IsNotNull(obj);
        }
    }
}
