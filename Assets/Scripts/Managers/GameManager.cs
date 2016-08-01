using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public enum GameState { Started, Paused }
    public GameState State { get; set; }

    void Awake()
    {
        State = GameState.Paused;
    }
}
