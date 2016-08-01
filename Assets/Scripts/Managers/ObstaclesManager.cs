using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstaclesManager : MonoBehaviour {
    [SerializeField]
    private GameObject _cactus;

    private List<GameObject> _obstacles = new List<GameObject>();

	// Use this for initialization
	void Start () {
        GameObject cactus = Instantiate(_cactus, new Vector3(0, -2.23f, 0), Quaternion.identity) as GameObject;
        _obstacles.Add(cactus);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
