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
    private bool dogIsActive;

    public float activationFrequency;
    // Start is called before the first frame update
    void Start()
    {
        dogWfs = new WaitForSeconds(activationFrequency);
        initiateDogs();
    }

    public IEnumerator DogRoutine()
    {
        yield return dogWfs;
        while (true)
        {
            if (!dogIsActive)
            {
                dogList[Random.Range(0, dogList.Count)].gameObject.SetActive(true);
                dogIsActive = true;
            }
            else
                yield return dogWfs;
        }
    }

    public void ResetCoroutine()
    {
        StopCoroutine(currentDogRoutine);
        initiateDogs();
        
    }
    public void dogDisabled()
    {
        dogIsActive = false;
    }

    private void initiateDogs()
    {
        dogIsActive = false;
        currentDogRoutine = StartCoroutine(DogRoutine());
    }
}
