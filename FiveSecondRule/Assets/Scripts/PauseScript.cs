using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
   public void SetTimeActive(bool active)
   {
      Time.timeScale = active ? 1.0f : 0;
   }
}
