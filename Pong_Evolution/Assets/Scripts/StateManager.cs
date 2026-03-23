using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public enum GameStates
    {
        Idle,
        Playing,
        GameOver
    }

    public GameStates currentState;
    public static StateManager Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentState = GameStates.Idle;
    }
}
