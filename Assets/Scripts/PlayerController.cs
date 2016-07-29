using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {
    public float jumpHeight = 7f;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector3(0, jumpHeight, 0);
        }
	}
}