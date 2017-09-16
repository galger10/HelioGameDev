using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	public int pointValue = 10;
	public virtual void OnTriggerEnter()
	{
		print ("Adding " + pointValue +" points.");
	}

}
