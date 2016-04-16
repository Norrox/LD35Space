using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

	// Use this for initialization
	void Start() {
	
	}

	// Update is called once per frame
	void LateUpdate() {
		Vector3 pos = GetComponentInParent<Transform>().position;
		if (Input.GetKey(KeyCode.W)) pos.y += 0.05f;
		if (Input.GetKey(KeyCode.S)) pos.y -= 0.05f;
		if (Input.GetKey(KeyCode.D)) pos.x += 0.05f;
		if (Input.GetKey(KeyCode.A)) pos.x -= 0.05f;
		GetComponentInParent<Transform>().position = pos;
	}
}
