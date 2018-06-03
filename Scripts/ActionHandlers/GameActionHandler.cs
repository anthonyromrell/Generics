using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;


public class GameActionHandler : MonoBehaviour
{
    public GameAction Action;
    public UnityEvent Event;
    
    private void OnEnable()
    {
        Action.CallNoArgs += Respond;
    }

    void  Respond() {
        Event.Invoke();
    }
}