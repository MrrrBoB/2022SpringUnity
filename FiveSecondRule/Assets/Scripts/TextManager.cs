using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public SpawnControl referenceObj;
    public Text counter;
    // Start is called before the first frame update
    public void UpdateText()
    {
        counter.text = "fixme";
    }

    private void Start()
    {
        UpdateText();
    }
}
