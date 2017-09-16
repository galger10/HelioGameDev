using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBullet : MonoBehaviour {
    public float rate = 2;
	public Transform gun;

    void OnEnable()
	{
		transform.position = gun.position;
		Invoke("Disable", rate);
	}

	void Disable () {
		gameObject.SetActive(false);
	}

}
