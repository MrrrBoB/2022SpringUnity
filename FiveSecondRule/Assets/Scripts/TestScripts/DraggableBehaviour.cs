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
        private float launchForce = 50f; 
        private float launchParameterTime= 0.5f;
        private float startTime, endTime;
        public Rigidbody2D body;
        private bool CanDrag { get; set; }
        public UnityEvent onDrag, onUp;
        public bool draggable;
        private float gravScale;

        private void Start()
        {
            cam = Camera.main;
            gravScale = body.gravityScale;
        }

        public IEnumerator OnMouseDown()
        {
            if (!draggable) yield break;
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
            if (draggable)
            {
                onUp.Invoke();
            }
            EnableGravity(true);
            body.velocity = Vector2.zero;
            if(endTime-startTime<=launchParameterTime)
                body.AddForce((newPosition-startPosition)/(endTime-startTime)*launchForce);
        }

        private void EnableGravity(bool active)
        {
            body.gravityScale = active ? gravScale : 0;
        }

        public void setDraggability(bool b)
        {
            draggable = b;
        }
        
       
    }
