using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsHealth : PowerUps {

	public override void OnTriggerEnter()
	{
		base.OnTriggerEnter();
		print ("Adding Health");
	}

}
