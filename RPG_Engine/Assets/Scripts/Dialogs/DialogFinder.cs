using UnityEngine;
using System.Linq;

namespace RPG_Engine.Dialogs
{
    [RequireComponent(typeof(Collider))]
    public class DialogFinder : MonoBehaviour
    {
        private const int BUFFER_SIZE = 20;
        private Collider[] _buffer;

        private Collider _collider;
        private global::System.Random _rng;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            _rng = new global::System.Random();
        }

        private void FixedUpdate()
        {
            _buffer = new Collider[BUFFER_SIZE];

            if(Physics.OverlapBoxNonAlloc(transform.position, _collider.bounds.extents * 1.5f, _buffer) > 0)
            {
                DialogTarget[] targets = _buffer.Where(b => b && b.GetComponent<DialogTarget>()).Select(b => b.GetComponent<DialogTarget>()).ToArray();
                
                if(targets.Length > 0 && Input.GetKey(KeyCode.Space))
                {
                    DialogTarget target = targets[_rng.Next(targets.Length)];
                    transform.LookAt(target.transform);
                    target.transform.LookAt(transform);

                    FindObjectOfType<DialogManager>().DisplayDialog(target.Text);
                }
            }
        }
    }
}

