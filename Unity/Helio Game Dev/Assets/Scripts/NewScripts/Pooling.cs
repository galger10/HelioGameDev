using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour {

	public List<GameObject> bullets;
	int i = 0;
    private bool canFire = true;

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.A)) {
			Fire();
		}
	}

	void Fire () {
		if (i < bullets.Count && canFire)
		{
			bullets[i].SetActive(true); 
			i++;
		} else {
			i = 0;
			canFire = false;
		}
		
	}
}
