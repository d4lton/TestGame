using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class CarManager : MonoBehaviour {
	public int playerId = 0; // The Rewired player id of this character
	private Player player; // The Rewired Player
	private Vector3 moveVector;

	private Rigidbody rb;

	void Awake() {
		player = ReInput.players.GetPlayer(playerId);
	}

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (player.GetAxis ("Thrust"));
		rb.AddForce (player.GetAxis ("Thrust"), 0, 0);
	}
}
