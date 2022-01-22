using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogAction : MonoBehaviour
{
    public void PrintSomething()
    {
        Debug.Log("Result!");
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject+" was tapped");
    }

    public void DeleteThisObject()
    {
        Destroy(gameObject);
    }
}
