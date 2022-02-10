using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SporeBehavior : BaseGermBehavior
{
    public Vector3 SpawnPoint;
    // Start is called before the first frame update
    protected override void Start()
    {
        SpawnPoint = new Vector3(Random.Range(-9, 9), 6);
        transform.position=SpawnPoint;
    }
    
}
