using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class KeyManagerLevelStar : MonoBehaviour
{
    public LevelKeyManager mgr;

    public int LevelKeyIndexToCheck;

    public GameObject img;
    // Start is called before the first frame update
    void Start()
    {
        CheckLevel();
    }

    public void CheckLevel()
    {
        img.SetActive(!mgr.getKeyStatus(LevelKeyIndexToCheck));
    }
    

}
