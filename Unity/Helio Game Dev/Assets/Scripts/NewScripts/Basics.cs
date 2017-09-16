using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ammo = AddAmmo(10, 100);
	}
	public int ammo = 0;
	public float health = 1.0f;
	public string playerName = "Bob";	

	void PlayGame (string _who) {
		print(_who + " is playing.");
	}
	int AddAmmo (int _storedAmmo, int _bonusAmmo) {
		return _storedAmmo + _bonusAmmo;
	}

}
