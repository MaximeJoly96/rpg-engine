using UnityEngine;

namespace RPG_Engine.Dialogs
{
    public class DialogManager : MonoBehaviour
    {
        [SerializeField]
        private Canvas _uiCanvas;
        [SerializeField]
        private GameObject _dialogPrompt;

        private GameObject _instPrompt;

        public void DisplayDialog(string text)
        {
            if (_instPrompt)
                Destroy(_instPrompt);

            _instPrompt = Instantiate(_dialogPrompt, _uiCanvas.transform);

            _instPrompt.GetComponent<DialogPrompt>().SetText(text);
        }
    }
}

