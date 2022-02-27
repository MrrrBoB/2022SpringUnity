using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GermCountData : ScriptableObject
{
    public int numGerms;
    public int holdCount;
    public UnityEvent numChangeEvent;
    public void ChangeGermCount(int val)
    {
        numGerms += val;
        numChangeEvent.Invoke();
    }

    public void InitializeCount(int iVal)
    {
        holdCount = iVal;
        ResetGermCountData();
    }

    public void ResetGermCountData()
    {
        numGerms = holdCount;
        numChangeEvent.Invoke();
    }

    public int GetGermCount()
    {
        return numGerms;
    }
}
