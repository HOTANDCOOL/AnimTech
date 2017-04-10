using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour {

	public float _强度=1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rd = GetComponent<Rigidbody>();
		if (rd == null) {
			return;
		}
		Vector3 localpos = transform.localPosition;
		Vector3 force = -localpos.normalized * _强度 * 0.01f;
		rd.AddForce (force);
			

	}
}
