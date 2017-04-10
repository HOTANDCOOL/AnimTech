using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resistance : MonoBehaviour {


	public float _阻力系数=0.1f;
	public float mass = 1.0f;
	private Vector3 acc;
	private Vector3 v=new Vector3(0,0,0);
	public float t = 0;
	// Use this for initialization
	void Start () {
		
		Vector3 F=new Vector3(1.0f,5.0f,0);
		acc = F / mass;

	}
	
	// Update is called once per frame
	void Update () {
		float time = Time.realtimeSinceStartup;


		Rigidbody rd = GetComponent<Rigidbody> ();

		if (rd == null) {
			return;
		}

		t += time;
		//Vector3 LocalPos = transform.localPosition;


		v += acc * time;
		//Vector3 force = LocalPos-v;

		rd.AddForce (-5*v.normalized);



		if(t > 5.0f) {
				acc -=v.normalized*_阻力系数 * v.magnitude* v.magnitude/ mass;
		}

	}
}
