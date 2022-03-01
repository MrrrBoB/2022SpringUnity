using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GermCountData : ScriptableObject
{
    public int numGerms;
    public UnityEvent winEvent;
    public UnityEvent updateEvent;

    public int GetGermCount()
    {
        return numGerms;
    }

    public void ChangeGermCount(int valueChanged)
    {
        numGerms += valueChanged;
        updateEvent?.Invoke();
        if(numGerms<=0) winEvent?.Invoke();
    }

    public void SetGermCount(int val)
    {
        updateEvent?.Invoke();
        numGerms = val;
    }
    
    
}
