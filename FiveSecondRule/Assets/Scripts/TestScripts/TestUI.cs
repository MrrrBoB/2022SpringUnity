using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : MonoBehaviour
{
    public Canvas cvs;
    // Start is called before the first frame update
    public void EnableCanvas(bool hideSwitch)
    {
        cvs.enabled = hideSwitch;
    }
}
