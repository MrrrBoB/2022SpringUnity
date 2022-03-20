using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DogManager : MonoBehaviour
{
    public List<GameObject> dogList;
    private WaitForSeconds dogWfs;
    private Coroutine currentDogRoutine;
    public float activationFrequencyMin;
    public float activationFrequencyMax;
    // Start is called before the first frame update
    void Start()
    {
        dogWfs = new WaitForSeconds(Random.Range(activationFrequencyMin, activationFrequencyMax));
        initiateDogs();
    }

    public IEnumerator DogRoutine()
    {
        yield return dogWfs;
        dogList[Random.Range(0, dogList.Count)].gameObject.SetActive(true);
        
    }

    public void ResetCoroutine()
    {
        StopCoroutine(currentDogRoutine);
        initiateDogs();
        
    }
    public void dogDisabled()
    {
        initiateDogs();
    }

    private void initiateDogs()
    {
        currentDogRoutine = StartCoroutine(DogRoutine());
    }
}
