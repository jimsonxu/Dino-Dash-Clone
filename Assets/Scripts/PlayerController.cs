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
            if (Managers.Game.State == GameManager.GameState.Paused)
            {
                Managers.Game.State = GameManager.GameState.Started;
            }
            else
            {
                rigidBody.velocity = new Vector3(0, jumpHeight, 0);
            }
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Messenger.Broadcast(GameEvent.PlayerHitSomething);
        }
    }
}
