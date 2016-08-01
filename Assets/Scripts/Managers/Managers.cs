using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ObstaclesManager))]
public class Managers : MonoBehaviour {
    public static ObstaclesManager Obstacles;

	// Use this for initialization
	void Start () {
        Obstacles = new ObstaclesManager();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
