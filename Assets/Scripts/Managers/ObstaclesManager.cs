using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstaclesManager : MonoBehaviour {
    [SerializeField]
    private GameObject _cactus = null;
    [SerializeField]
    private float moveSpeed = 5.0f;

    private List<GameObject> _obstacles = new List<GameObject>();

	// Use this for initialization
	void Start () {
        GameObject cactus = Instantiate(_cactus, new Vector3(1f, -2.23f, 0), Quaternion.identity) as GameObject;
        _obstacles.Add(cactus);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Managers.Game.State == GameManager.GameState.Started)
        {
            foreach (GameObject obstacle in _obstacles)
            {
                Vector3 movement = new Vector3(-moveSpeed, 0, 0);
                obstacle.transform.position += movement * Time.deltaTime;
            }
        }
	}
}
