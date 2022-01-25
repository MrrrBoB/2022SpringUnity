using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnList : MonoBehaviour
{
    public List<GameObject> listOfObjects;
    public float spawnFrequency;
    private WaitForSeconds wfs;
    public UnityEvent spawnEvent;

    void Start()
    {
        wfs = new WaitForSeconds(spawnFrequency);
    }

    public IEnumerator SpawnRoutine()
    {
        yield return wfs;
        while (listOfObjects.Count>0)
        {
            
        }
    }

}
