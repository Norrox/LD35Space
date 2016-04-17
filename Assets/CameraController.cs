using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	const float ZOOMSPEED = 0.5f;

	Camera cam;

	Transform pst;
	Transform t;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();

		pst = GameObject.Find("PlayerSprite").GetComponent<Transform>();
		t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		t.position = new Vector3(pst.position.x, pst.position.y, t.position.z);

		if (Input.mouseScrollDelta.y != 0) cam.orthographicSize -= Input.mouseScrollDelta.y*ZOOMSPEED;

		GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().text = "SCROLLDELTA: " + Input.mouseScrollDelta.ToString();
	}
}
