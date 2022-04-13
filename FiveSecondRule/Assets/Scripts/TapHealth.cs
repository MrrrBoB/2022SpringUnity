using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class TapHealth : MonoBehaviour
{
    private int health;
    public int maxHealth;
    public UnityEvent destroyEvent;
    public ParticleSystem pSys;
    public AudioClip crunchSound;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(gameObject.layer, gameObject.layer, true);
        health = maxHealth;
    }

    public void OnMouseDown()
    {
        health -= 1;
        Instantiate(pSys, gameObject.transform.position, quaternion.identity);
        AudioSource.PlayClipAtPoint(crunchSound, gameObject.transform.position);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
