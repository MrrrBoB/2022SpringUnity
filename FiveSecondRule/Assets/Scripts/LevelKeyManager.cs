using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class LevelKeyManager : ScriptableObject
{
    public bool[] levelKeys;

    public UnityEvent SaveEvent;
    // Start is called before the first frame update
    public void gainKeyToLevel(int levelKeyIndex)
    {
        levelKeys[levelKeyIndex] = true;
        SaveEvent.Invoke();
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
        SaveEvent.Invoke();
    }
    
    
}
