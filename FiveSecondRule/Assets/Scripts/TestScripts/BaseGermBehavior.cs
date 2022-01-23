using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGermBehavior : MonoBehaviour
{
    
    public float moveFrequency;
    public GameObject target;
    protected Vector2 destination;
    private WaitForSeconds wfs;
    public Rigidbody2D body;
    protected virtual void Start()
    {
        destination = target.transform.position;
        wfs = new WaitForSeconds(moveFrequency);
        StartCoroutine(MoveTowardsTarget());

    }

    public virtual void Evolve()
    {
        Debug.Log("Evolved");
    }


    protected virtual void MoveForward()
    {
        Debug.Log("BaseMove");
    }

    private IEnumerator MoveTowardsTarget()
    {
        yield return wfs;
        Debug.Log("StartedMoving");
        while (true)
        {
            yield return wfs;
            MoveForward();
            Debug.Log("Moved");
        }
    }
}
