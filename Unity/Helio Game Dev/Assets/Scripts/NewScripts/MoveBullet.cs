using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	Rigidbody bullet;
	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		bullet.AddForce(25,0,0);
	}

	void OnDisable()
	{
		bullet.Sleep();
	}
}
