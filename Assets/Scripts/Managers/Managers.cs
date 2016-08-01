using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ObstaclesManager))]
[RequireComponent(typeof(ObstaclesManager))]
public class Managers : MonoBehaviour {
    public static GameManager Game;
    public static ObstaclesManager Obstacles;

	// Use this for initialization
	void Awake () {
        Game = GetComponent<GameManager>();
        Obstacles = GetComponent<ObstaclesManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
