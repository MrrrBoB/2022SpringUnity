using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaBehavior : BaseGermBehavior
{
    void Start()
    {
        Evolve();
    }

    public new void Evolve()
    {
        Debug.Log("Hardened");
    }
    
}
