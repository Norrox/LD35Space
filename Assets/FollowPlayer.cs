using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	GameObject PlayerSprite;
	Transform pst;
	Transform t;

	// Use this for initialization
	void Start () {
		PlayerSprite = GameObject.Find("PlayerSprite");
		pst = PlayerSprite.GetComponent<Transform>();
		t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = pst.position;
		pos.z = t.position.z;
		t.position = pos;
	}
}
