using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class SpriteChange : MonoBehaviour
{
    public int ArraySize;
    public Sprite[] SpriteStages;
    public int currentShellHitPoints;
    public SpriteRenderer sDisplay;
    public UnityEvent OnShellBreak;
    public bool hasShell = true;
    void Start()
    {
        ArraySize = SpriteStages.Length;
        currentShellHitPoints = ArraySize-1;
    }
    public void OnMouseDown()
    {
        if (!hasShell) return;
        if (currentShellHitPoints <= 0)
        {
            OnShellBreak.Invoke();
            hasShell = false;
        }
        else
        {
            CrackShell();
            UpdateSprite();
        }

    }
    // Update is called once per frame
     private void UpdateSprite()
    {
        sDisplay.sprite = SpriteStages[currentShellHitPoints];
    }

     public void TestDebug()
     {
         Debug.Log("ChangeSprite");
     }

     private void CrackShell()
     {
         currentShellHitPoints -= 1;
     }
}
