using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehavior : BaseGermBehavior
{
    public ForceMode2D torque;

    public float rotational;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        body.AddTorque(rotational,torque);
    }

    protected override void MoveForward()
    {
        direction = target.transform.position - transform.position;
        body.AddForce(direction*moveForce);
    }
    
}
