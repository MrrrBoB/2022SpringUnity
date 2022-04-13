using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public abstract class BaseGermBehavior : MonoBehaviour
{
    public ParticleSystem pSys;
    private WaitForSeconds wfs;
    protected Rigidbody2D body;
    protected Vector2 direction, destination;
    public GameObject target;
    [Header("Movement")]
    public float moveForce;
    public float moveFrequency;
    public float speedMultiplier;
    public AudioSource Plyr;
    public AudioClip[] soundList;
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
            yield return wfs;
        }
    }

    public void ChangeSpeed(bool increase)
    {
        moveFrequency *= increase ? speedMultiplier:(1/speedMultiplier);
        wfs = new WaitForSeconds(1/moveFrequency);
    }

    public void createParticles()
    {
        Instantiate(pSys, gameObject.transform.position, quaternion.identity);
    }

    public void playRandomSound()
    {
        AudioSource.PlayClipAtPoint(soundList[Random.Range(0, soundList.Length - 1)], gameObject.transform.position);
    }
    

}
