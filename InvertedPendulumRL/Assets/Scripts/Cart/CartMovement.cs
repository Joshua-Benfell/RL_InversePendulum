using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script to allow a person to move the cart
public class CartMovement : MonoBehaviour {
	// Start is called before the first frame update

	public float speed = 100f;
	private Rigidbody2D rb2d;
	private float moveHorizontal;


	void Start() {
		rb2d = GetComponent<Rigidbody2D>();
	}

	// FixedUpdate is called at a fixed time interval
	void FixedUpdate() {
		moveHorizontal = Input.GetAxis("Horizontal");
		Vector2 movement = new Vector2(moveHorizontal, 0);
		rb2d.AddForce(movement*speed);
	}
}
