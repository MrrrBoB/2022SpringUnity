using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SporeBehavior : BaseGermBehavior
{
    public Vector3 SpawnPoint;

    public GameObject mushroom;
    // Start is called before the first frame update
    protected override void Start()
    {
        SpawnPoint = new Vector3(Random.Range(-9, 9), 6);
        if (SpawnPoint.x >= -3 && SpawnPoint.x < 3) SpawnPoint.x = 3; 
        transform.position=SpawnPoint;
    }

    public void SpawnMushrrom()
    {
        Instantiate(mushroom, new Vector3(SpawnPoint.x,-1.65f, -1f), Quaternion.identity);
    }
}
