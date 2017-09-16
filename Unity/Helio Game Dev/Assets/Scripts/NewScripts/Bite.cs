using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bite : MonoBehaviour {

	Animator anims;

	// Use this for initialization
	void Start () {
		anims = GetComponent<Animator>();
		Invoke("Swim", 2);
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		anims.SetTrigger("Bite");
	}

	void Swim () {
		anims.SetFloat("Swim", 1);
		Invoke("Idle", 1);
	}

	void Idle () {
		anims.SetFloat("Swim", 0);
	}
}
