using UnityEngine;
using System.Collections;

public class StarfieldScroll : MonoBehaviour {
	
    float parralax = 2f;
	// Update is called once per frame
	void Update () {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Camera cam = FindObjectOfType<Camera>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x = transform.position.x / transform.localScale.x / parralax;
        offset.y = transform.position.y / transform.localScale.y / parralax;

        mat.mainTextureOffset = offset;
        this.transform.rotation = cam.transform.rotation;
	}
}
