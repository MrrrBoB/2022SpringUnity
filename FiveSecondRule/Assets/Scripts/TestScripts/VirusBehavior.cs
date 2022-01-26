using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehavior : BaseGermBehavior
{
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    protected override void MoveForward()
    {
        direction = target.transform.position - transform.position;
        body.AddForce(direction*moveForce);
    }
    
}
