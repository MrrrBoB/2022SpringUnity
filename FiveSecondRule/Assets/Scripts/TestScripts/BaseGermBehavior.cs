using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGermBehavior : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    public virtual void Evolve()
    {
        Debug.Log("Evolved");
    }

    public void AdvanceForward()
    {
        Debug.Log("Moved");
    }

    public virtual void moveForward()
    {
        
    }


}
