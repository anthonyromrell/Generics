using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotDragTest : DragRotationBase
{
	float x, y, z;
	public TransformType.Axis Axis;
	
	public float MinLimit;
	public float MaxLimit;
	private float rotation;

	private void Start()
	{
		x = transform.localEulerAngles.x;
		y = transform.localEulerAngles.y;
		z = transform.localEulerAngles.z;
	}

	public override void OnMouseDrag () {

		rotation += Input.GetAxis(AxisName) * Speed;
		rotation = Mathf.Clamp(rotation, MinLimit, MaxLimit);

		switch (Axis)
		{	
			case TransformType.Axis.RotationX:
				x += rotation;
				break;
			case TransformType.Axis.RotationY:
				y += rotation;
				break;
			case TransformType.Axis.RotationZ:
				z += rotation;
				break;
			case TransformType.Axis.None:
				break;
		}

		//transform.localEulerAngles = Vectors;
		transform.rotation = Quaternion.Euler(x,y,z);
	}
}
