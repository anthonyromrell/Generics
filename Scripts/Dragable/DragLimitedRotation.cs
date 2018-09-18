using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Draggable", menuName = "Draggable/Drag With Limited Rotation")]
public class DragLimitedRotation : DragRotationBase
{
    public float MinLimit;
    public float MaxLimit;
    private float rotation;

    private void OnMouseDown()
    {
        switch (CurrentMovement)
        {
            case TransformType.Axis.RotationX:
                rotation = transform.localEulerAngles.x;
                break;
            case TransformType.Axis.RotationY:
                rotation = transform.localEulerAngles.y;
                break;
            case TransformType.Axis.RotationZ:
                rotation = transform.localEulerAngles.z;
                break;
            case TransformType.Axis.None:
                break;
        }  
    }

    public override void OnMouseDrag()
    {
        rotation += Input.GetAxis(AxisName) * Speed;
        rotation = Mathf.Clamp(rotation, MinLimit, MaxLimit);
        switch (CurrentMovement)
        {
            case TransformType.Axis.RotationX:
                Vectors.Set(rotation, transform.localEulerAngles.y, transform.localEulerAngles.z);
                break;
            case TransformType.Axis.RotationY:
                Vectors.Set(transform.localEulerAngles.x, rotation, transform.localEulerAngles.z);
                break;
            case TransformType.Axis.RotationZ:
                Vectors.Set(transform.localEulerAngles.x, transform.localEulerAngles.y, rotation);
                break;
            case TransformType.Axis.None:
                break;
        }
        
        transform.localEulerAngles = Vectors;
    }
}