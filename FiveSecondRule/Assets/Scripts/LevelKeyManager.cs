using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class LevelKeyManager : ScriptableObject
{
    public bool[] levelKeys;

    public bool hasReset;
    // Start is called before the first frame update
    public void FirstTimeResetCheck()
    {
        if (!hasReset)
        {
            ResetProgress();
            hasReset = true;
            Debug.Log("reset levels");
        }
    }

    public void gainKeyToLevel(int levelKeyIndex)
    {
        levelKeys[levelKeyIndex] = true;
    }

    public bool getKeyStatus(int keyIndex)
    {
        return levelKeys[keyIndex];
    }

    public void ResetProgress()
    {
        for(int i = 1; i < levelKeys.Length; i++)
        {
            levelKeys[i] = false;
        }
    }
    
    
}
