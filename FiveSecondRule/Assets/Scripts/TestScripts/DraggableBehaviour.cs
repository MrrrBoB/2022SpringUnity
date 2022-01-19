using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class DraggableBehaviour : MonoBehaviour
    {
        private Vector3 offsetPosition;
        private Vector3 newPosition;
        private Vector3 startPosition;
        private Camera cam;
        public float launchForce, launchParameterTime;
        private float startTime, endTime;
        public Rigidbody2D body;
        private bool CanDrag { get; set; }
        public UnityEvent onDrag, onUp;
        public bool Draggable { get; set; }

        private void Start()
        {
            cam = Camera.main;
            Draggable = true;
        }

        public IEnumerator OnMouseDown()
        {
            onDrag.Invoke();
            startTime = Time.time;
            startPosition = transform.position;
            offsetPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
            EnableGravity(false);
            yield return new WaitForFixedUpdate();
            CanDrag = true;
            
            while (CanDrag)
            {
                yield return new WaitForFixedUpdate();
                newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + offsetPosition;
                transform.position = newPosition;
            }
        }

        private void OnMouseUp()
        {
            CanDrag = false;
            endTime = Time.time;
            if (Draggable)
            {
                onUp.Invoke();
            }
            EnableGravity(true);
            if(endTime-startTime<=launchParameterTime)
                body.AddForce((newPosition-startPosition)/(endTime-startTime)*launchForce);
        }

        private void EnableGravity(bool active)
        {
            body.gravityScale = active ? 3 : 0;
        }
       
    }
