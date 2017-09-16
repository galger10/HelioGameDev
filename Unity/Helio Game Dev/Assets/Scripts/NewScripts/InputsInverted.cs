using UnityEngine;
using System;
public class InputsInverted : InputsStandard {

	// Use this for initialization
	void Update () {
		StandardInput(KeyCode.DownArrow, Vector3.up);
		StandardInput(KeyCode.UpArrow, Vector3.down);
		StandardInput(KeyCode.RightArrow, Vector3.forward);
		StandardInput(KeyCode.LeftArrow, Vector3.back);
	}
}
