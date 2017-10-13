using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BulletController : MonoBehaviour {

	public float speed;
	public GameObject bullet;

	private PenguinController player;


	AudioSource audio;
	public AudioClip slimeDeathSound;

	public GameObject slimeDeathEffect;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PenguinController> ();
		audio = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, 0.0f);

		if (player.transform.localScale.x < 0) {

			speed = -speed;

		}
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.tag == "Enemy") {
			
			audio.PlayOneShot (slimeDeathSound, 1.0f);
			Instantiate (slimeDeathEffect, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);

		}
		if (other.tag == "Bullet Container") {

			Destroy (gameObject);

		}
	} 
}
