using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that randomly pushes the weight on the pendulum
public class RandomisedStartForce : MonoBehaviour {
	
	private Vector2 force;
	private Rigidbody2D rb2d;
	
	// Start is called before the first frame update
	void Awake() {
		rb2d = GetComponent<Rigidbody2D>();
		force.x = Random.Range(-5,5);
		force.y = 0;
		rb2d.AddForce(force, ForceMode2D.Impulse);
	}
}

