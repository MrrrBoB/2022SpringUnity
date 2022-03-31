using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateBehavior : MonoBehaviour
{
    public GameStates gameStates;
    public UnityEvent startingEvent, playingEvent, returningEvent;

    public void checkGameStates()
    {
        switch (gameStates.currentState)
        {
            case GameStates.States.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.States.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.States.Returning:
                returningEvent.Invoke();
                break;
            default:
                startingEvent.Invoke();
                break;
        }
    }
    
    
}
