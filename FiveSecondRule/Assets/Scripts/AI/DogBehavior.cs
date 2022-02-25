using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class DogBehavior : MonoBehaviour
{
    private float gScale;
    private Rigidbody2D body;
    private Vector3 launchDirection;
    public float tapLaunchStrength;
    private Vector2 resetLocation;
    public UnityEvent signalSpawner;

    private void Start()
    {
        launchDirection = new Vector3(0, 10*tapLaunchStrength, 0);
        body = gameObject.GetComponent<Rigidbody2D>();
        gScale = body.gravityScale;
        Physics2D.IgnoreLayerCollision(gameObject.layer, 6, true);
        Physics2D.IgnoreLayerCollision(gameObject.layer, 0, true);
        resetLocation = gameObject.transform.position;
    }

    

    private void OnMouseDown()
    {
        body.AddForce(launchDirection);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       resetDog();
    }

    public void resetDog()
    {
        gameObject.transform.position = resetLocation;
        gameObject.SetActive(false);
    }
}
