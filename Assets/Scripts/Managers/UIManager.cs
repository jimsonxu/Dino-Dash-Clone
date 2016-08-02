using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {
    private GameObject _gameStatus;

    void Awake()
    {
        Messenger.AddListener(GameEvent.PlayerHitSomething, ShowGameOver);
    }

	// Use this for initialization
	void Start () {
        _gameStatus = transform.Find("Game Status").gameObject;
        _gameStatus.SetActive(false);
	}
	
	void ShowGameOver()
    {
        Messenger.RemoveListener(GameEvent.PlayerHitSomething, ShowGameOver);
        _gameStatus.SetActive(true);
    }
}
