using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsDeath : PowerUps {

	public override void OnTriggerEnter()
	{
		base.OnTriggerEnter();
		print ("Substracting Health");
	}

}
