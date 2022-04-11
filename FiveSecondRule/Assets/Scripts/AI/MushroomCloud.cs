using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MushroomCloud : MonoBehaviour
{
  public Collider2D col;
  public SpriteRenderer cloud;
  public float activeMushrooms = 0;

  public void ChangeActiveCount(float num)
  {
    activeMushrooms += num;
    col.enabled = (activeMushrooms > 0);
    cloud.enabled = (activeMushrooms > 0);
  }


}
