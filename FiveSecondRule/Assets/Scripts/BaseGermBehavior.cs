using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGermBehavior : MonoBehaviour
{
    void Start()
    {
        Evolve();
    }

    public void Evolve()
    {
        Debug.Log("Evolved");
    }

    public void AdvanceForward()
    {
        Debug.Log("Moved");
    }


}
