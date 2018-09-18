using UnityEngine;

[CreateAssetMenu(fileName = "Draggable", menuName = "Draggable/Drag With Rotation")]
public class DragFreeRotation : DragRotationBase
{
	private float distance;
	
	public override void OnMouseDrag()
	{
		distance = Input.GetAxis(AxisName) * Speed;
	
		switch (CurrentMovement)
		{
			case TransformType.Axis.RotationX:
				transform.Rotate(Vector3.right, -distance);
				break;

			case TransformType.Axis.RotationY:
				transform.Rotate(Vector3.up, -distance);
				break;

			case TransformType.Axis.RotationZ:
				transform.Rotate(Vector3.forward, -distance);
				break;
			case TransformType.Axis.None:
				break;
		}
	}
}