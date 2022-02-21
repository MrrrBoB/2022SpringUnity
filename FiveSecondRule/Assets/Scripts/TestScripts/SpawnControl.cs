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
    public List<GameObject> listOfObjects, dogList;
    public float spawnFrequency;
    private WaitForSeconds wfs, dogWfs;
    private Coroutine currentRoutine, currentDogRoutine;
    public bool dogsEnabled;
    [Header("Viruses")]
    public int virusCount;
    public GameObject virusObj;
    [Header("Bacteria")]
    public int bacteriaCount;
    public GameObject bacteriaObj;
    [Header("Spores")] 
    public int sporeCount;
    public GameObject SporeObj;
    [Header("GermCounterData")] 
    public GermCountData countObj;

    private void Start()
    {
        wfs = new WaitForSeconds(spawnFrequency);
        dogWfs = new WaitForSeconds(spawnFrequency * 5);
        currentDogRoutine = null;
        Initiate();
    }

    private void Initiate()
    {
        if (dogsEnabled)
        {
            currentDogRoutine = StartCoroutine(DogRoutine());
        }
        currentRoutine =StartCoroutine(SpawnRoutine());
        FillList();
        countObj.SetGermCountData(listOfObjects.Count);
    }
    
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

    public IEnumerator DogRoutine()
    {
        Debug.Log("Dogs!");
        yield break;
    }

    private void AddToList(int numToAdd, GameObject obj)
    {
        if (numToAdd <= 0) return;
        for (int i = 0; i < numToAdd; i++)
        {
            listOfObjects.Add(obj);
        }
    }

    public void FillList()
    {
        AddToList(virusCount,virusObj);
        AddToList(bacteriaCount, bacteriaObj);
        AddToList(sporeCount,SporeObj);
    }

    public void ResetSpawner()
    {
        StopCoroutine(currentRoutine);
        if(dogsEnabled) StopCoroutine(DogRoutine());
        listOfObjects.Clear();
        Initiate();
    }
}
