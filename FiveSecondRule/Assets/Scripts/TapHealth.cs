using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TapHealth : MonoBehaviour
{
    private int health;
    public int maxHealth;
    public UnityEvent destroyEvent;

    private void Start()
    {
        health = maxHealth;
    }

    public void OnMouseDown()
    {
        health -= 1;
        if (health <= 0)
        {
            destroyEvent?.Invoke();
            Destroy(gameObject);
        }
    }
}
