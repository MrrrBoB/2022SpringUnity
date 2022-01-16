using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public int ArraySize;
    public Sprite[] SpriteStages;
    public int CurrentHitPoints;
    public SpriteRenderer sDisplay;
    void Start()
    {
        ArraySize = SpriteStages.Length;
        CurrentHitPoints = ArraySize;
    }
    public void TapEvent()
    {
        CurrentHitPoints -= 1;
        if (CurrentHitPoints <= 0)
        {
            Destroy(this.GameObject());
        }
        else
        {
            UpdateSprite();
        }
    }
    // Update is called once per frame
     private void UpdateSprite()
    {
        sDisplay.sprite = SpriteStages[CurrentHitPoints-1];
    }

     public void TestDebug()
     {
         Debug.Log("ChangeSprite");
     }
}
