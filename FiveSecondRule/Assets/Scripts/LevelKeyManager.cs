using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelKeyManager : ScriptableObject
{
    public bool[] levelKeys;
    // Start is called before the first frame update
    public void gainKeyToLevel(int levelKeyIndex)
    {
        levelKeys[levelKeyIndex] = true;
    }

    public bool getKeyStatus(int keyIndex)
    {
        return levelKeys[keyIndex];
    }
    
}
