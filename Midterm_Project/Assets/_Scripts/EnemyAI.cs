using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float speed;
	Rigidbody2D enemyBody;
	Transform enemyPosition;
	float enemyWidth;
	float enemyHeight;
	public LayerMask enemyMask;
	bool isGrounded;
	bool isBlocked;

	// Use this for initialization
	void Start () {

		SpriteRenderer enemySprite = this.GetComponent<SpriteRenderer> ();
		enemyBody = this.GetComponent<Rigidbody2D> ();

		enemyWidth = enemySprite.bounds.extents.x;
		enemyHeight = enemySprite.bounds.extents.y;

		enemyPosition = this.transform;

		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector2 lineCastPos = enemyPosition.position.toVector2 () - enemyPosition.right.toVector2 () * enemyWidth + Vector2.up * enemyHeight * 0.5f;

		bool isGrounded = Physics2D.Linecast (lineCastPos, lineCastPos + Vector2.down, enemyMask);

		bool isBlocked = Physics2D.Linecast (lineCastPos, lineCastPos - enemyPosition.right.toVector2 () * .05f) ;

		Debug.DrawLine (lineCastPos, lineCastPos - enemyPosition.right.toVector2 () * .05f);

		Debug.DrawLine (lineCastPos, lineCastPos + Vector2.down);

		Vector2 myVelocity = enemyBody.velocity;
		myVelocity.x = enemyPosition.right.x * -speed;
		enemyBody.velocity = myVelocity;

		if (!isGrounded || isBlocked) {
			Vector3 currRot = enemyPosition.eulerAngles;
			currRot.y += 180;
			enemyPosition.eulerAngles = currRot;
		}
		
	}
		


}
