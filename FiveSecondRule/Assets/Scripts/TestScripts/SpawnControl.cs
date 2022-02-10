using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class SpawnControl : MonoBehaviour
{
    public Vector2[] spawnPoints;
    public List<GameObject> listOfObjects;
    public float spawnFrequency;
    private WaitForSeconds wfs;
    [Header("Viruses")]
    public int virusCount;
    public GameObject virusObj;
    [Header("Bacteria")]
    public int bacteriaCount;
    public GameObject bacteriaObj;
    [Header("Spores")] 
    public int sporeCount;
    public GameObject SporeObj;

    private void Start()
    {
        wfs = new WaitForSeconds(spawnFrequency);
        StartCoroutine(SpawnRoutine());
        AddToList(virusCount,virusObj);
        AddToList(bacteriaCount, bacteriaObj);
        AddToList(sporeCount,SporeObj);
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

    private void AddToList(int numToAdd, GameObject obj)
    {
        if (numToAdd <= 0) return;
        for (int i = 0; i < numToAdd; i++)
        {
            listOfObjects.Add(obj);
        }
    }
}
