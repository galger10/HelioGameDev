using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerDrop : MonoBehaviour {

	public AudioSource hammerSound;
	void OnCollisionEnter () {
		hammerSound.Play();
	}

}
