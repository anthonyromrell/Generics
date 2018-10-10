using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeColor : ScriptableObject
{
    public Color ObjectColor = Color.blue;
    
    public void ColorChange(SpriteRenderer sprite)
    {
        sprite.color = ObjectColor;
    }
}