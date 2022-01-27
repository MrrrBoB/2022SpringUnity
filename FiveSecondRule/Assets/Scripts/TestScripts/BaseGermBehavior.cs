using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public abstract class BaseGermBehavior : MonoBehaviour
{
    
    public float moveFrequency;
    public GameObject target;
    protected Vector2 destination;
    private WaitForSeconds wfs;
    protected Rigidbody2D body;
    protected Vector2 direction;
    public float moveForce;
    //public Collider2D bodyCol;
    protected virtual void Start()
    {
        destination = target.transform.position;
        wfs = new WaitForSeconds(moveFrequency);
        body = gameObject.GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(gameObject.layer, gameObject.layer, true);
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

    protected IEnumerator MoveTowardsTarget()
    {
        while (true)
        {
            MoveForward();
            Debug.Log("Moved");
            yield return wfs;
        }
    }
}
