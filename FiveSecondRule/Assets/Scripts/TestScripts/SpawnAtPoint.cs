using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class SpawnAtPoint : MonoBehaviour
{
    public Vector2[] spawnPoints;
    public List<GameObject> listOfObjects;
    public float spawnFrequency;
    private WaitForSeconds wfs;

    private void Start()
    {
        wfs = new WaitForSeconds(spawnFrequency);
        StartCoroutine(SpawnRoutine());
    }

    // Start is called before the first frame update
    public void SpawnAtRandomPoint(GameObject obj)
    {
        SpawnThing(spawnPoints[Random.Range(0,spawnPoints.Length)], obj);
    }

   
    public void SpawnAtSetPoint(int i, GameObject obj)
    {
        SpawnThing(spawnPoints[i], obj);
    }

    public void SpawnAtAllPoints(GameObject obj)
    {
        foreach (Vector2 spot in spawnPoints)
        {
            SpawnThing(spot, obj);
        }
    }
    private void SpawnThing(Vector2 location, GameObject thingToSpawn)
    {
        Instantiate(thingToSpawn, location, quaternion.identity);
    }
    public IEnumerator SpawnRoutine()
    {
        yield return wfs;
        while (listOfObjects.Count>0)
        {
            int i = Random.Range(0, listOfObjects.Count - 1);
            SpawnAtRandomPoint(listOfObjects[i]);
            listOfObjects.RemoveAt(i);
            yield return wfs;
        }
    }
}
