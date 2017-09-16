using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public static Action<float> SendHealth; 
	public float health = 1.0f;
	
	void Start()
	{
		SendHealth(health);
	}
}
