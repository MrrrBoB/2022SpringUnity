using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public float launchForce;
    // Start is called before the first frame update
    public void SimpleLaunch(Rigidbody2D body, Vector2 direction)
    {
        body.AddForce(direction*launchForce);
    }

    // Update is called once per frame
    public void CalculatedLaunch(Rigidbody2D body, Vector3 startPos, Vector3 endPos, float startTime, float endTime)
    {
        body.AddForce((endPos-startPos)/(endTime-startTime)*launchForce);
    }
}
