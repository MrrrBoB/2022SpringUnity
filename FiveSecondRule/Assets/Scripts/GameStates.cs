using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameStates : ScriptableObject
{
    public enum States
    {
        Starting,
        Playing,
        Returning
    }

    public States currentState;
}
