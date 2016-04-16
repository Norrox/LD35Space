using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	const float ROTATESPEED = 8f;

	float RotationSpeed = 0f;

	// Use this for initialization
	void Start() {
//		Vector2 com = GetComponentInParent<Rigidbody2D>().centerOfMass;
//		com.y -= 0.1f;
//		GetComponentInParent<Rigidbody2D>().centerOfMass = com;
	}

	// Update is called once per frame
	void FixedUpdate() {
		Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();

		if (Input.GetKey(KeyCode.D)) RotationSpeed += -ROTATESPEED;
		if (Input.GetKey(KeyCode.A)) RotationSpeed += ROTATESPEED;
		rb.MoveRotation(rb.rotation + RotationSpeed * Time.fixedDeltaTime);

		//t.forward
		if (Input.GetKey(KeyCode.W)) rb.AddRelativeForce(new Vector2(0f, 1f));
		if (Input.GetKey(KeyCode.S)) rb.AddRelativeForce(new Vector2(0f, -1f));
	}
}
