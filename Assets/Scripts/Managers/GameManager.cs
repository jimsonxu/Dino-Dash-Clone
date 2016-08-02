using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public enum GameState { Started, Paused, Over }
    public GameState State { get; set; }

    void Awake()
    {
        State = GameState.Paused;
        Messenger.AddListener(GameEvent.PlayerHitSomething, GameOver);
    }

    void GameOver()
    {
        Messenger.RemoveListener(GameEvent.PlayerHitSomething, GameOver);
        State = GameState.Over;
    }
}
