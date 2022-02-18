using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GermCountData : ScriptableObject
{
    public int numGerms;
    public UnityEvent numChangeEvent;
    public void ChangeGermCount(int val)
    {
        numGerms += val;
        numChangeEvent.Invoke();
    }

    public void SetGermCountData(int val)
    {
        numGerms = val;
        numChangeEvent.Invoke();
    }

    public int GetGermCount()
    {
        return numGerms;
    }
}
