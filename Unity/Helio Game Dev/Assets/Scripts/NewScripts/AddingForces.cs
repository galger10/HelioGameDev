using System;
using UnityEngine;

public class AddingForces : MonoBehaviour {

	Rigidbody shipRigidbody;
	public float force = 10;
	void Start () {
		shipRigidbody = GetComponent<Rigidbody>();
		InputsStandard.StandardInput += AddShipForce;
		InputsInverted.StandardInput += AddShipForce;
	}

	void AddShipForce (KeyCode _i, Vector3 _v) {
		if (Input.GetKey(_i))
		{
			shipRigidbody.AddForce(_v*force);
		}
	}
}
