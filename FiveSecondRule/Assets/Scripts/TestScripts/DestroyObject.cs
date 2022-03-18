using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float delayedDeathTime;
    public bool startTimerDeath;
    // Start is called before the first frame update
    public void Start()
    {
        if (startTimerDeath)
        {
            StartCoroutine(delayedDestroy(delayedDeathTime));
        }
    }

    public void DestroyThisObject()
    {
        Destroy(gameObject);
    }

    public void FireParticles(ParticleSystem pSys)
    {
        Instantiate(pSys,gameObject.transform.position, Quaternion.identity);
    }

    private IEnumerator delayedDestroy(float duration)
    {
        yield return new WaitForSeconds(duration);
        DestroyThisObject();
    }
    
}
