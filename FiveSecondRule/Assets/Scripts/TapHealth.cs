using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapHealth : MonoBehaviour
{
    private int health;
    public int maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    public void OnMouseDown()
    {
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
