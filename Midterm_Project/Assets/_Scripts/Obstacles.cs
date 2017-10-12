using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	private PlayerController player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.tag == "Player") {
		
			player.hurt = true;
			player.Damage (1);

		} else {
			player.hurt = false;
		}
	}
	
	// Update is called once per frame
	void OnTriggerExit2d (Collider2D other){
		if (other.gameObject.tag == "Player") {
			player.hurt = false;

		}
	}
}
