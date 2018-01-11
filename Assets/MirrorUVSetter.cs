using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorUVSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f), 0.0f);
        transform.rotation = Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Time.deltaTime * 120.0f, Time.deltaTime*120.0f, Time.deltaTime * 120.0f);

        var renderer = GetComponent<Renderer>();
        float x_comp = transform.forward.x;
        float y_comp = transform.forward.y;
        renderer.material.mainTextureOffset = new Vector2(-y_comp, x_comp);
	}
}
