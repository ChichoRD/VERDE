using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public enum GameState
{
    Menu,
    Playing,
    Paused,
    GameOver,
    Transition
}

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    UnityEvent<GameState> onGameStateChanged = new UnityEvent<GameState>();

    public Vector3 shopExit;

    public bool[] shopVisited = new bool[3];

    public LinkStats linkStats;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
            transform.GetChild(0).gameObject.SetActive(true);
            linkStats.Reset();
        }

        
    }

    

    public void ChangeStateOfGame(GameState state) {
        switch (state) {
            case GameState.Menu:
                break;
            case GameState.Playing:
                break;
            case GameState.Paused:
                break;
            case GameState.GameOver:
                break;
            default:
                break;
        }
        onGameStateChanged.Invoke(state);
    }
}
