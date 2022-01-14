using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    private Vector2 startPos, endPos, direction;
    private float touchtTimeStart, touchTimeFinish, timeInterval;
    private Rigidbody rB;
    private bool throwAllowed = true;

    [Range(0.05f, 1f)] public float throwForce = 0.3f;
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchtTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && throwAllowed)
        {
            touchTimeFinish = Time.time;

            timeInterval = touchTimeFinish - touchtTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;

            rB.isKinematic = false;
            rB.AddForce((-direction/timeInterval * throwForce));

            throwAllowed = false;
        }
    }
}
