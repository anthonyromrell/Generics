﻿using UnityEngine;

public class DragRotClick : DragRotationBase
{
	private bool canRot = true;
	
	public override void OnMouseDrag()
	{
		canRot = true;
	}
}