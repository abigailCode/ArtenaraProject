using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RotationSettings", menuName = "Custom/RotationSettings")]
public class RotationSettings : ScriptableObject
{
    public float rotationSpeed = 1.0f;
    public Vector3 rotationAxis = Vector3.up;
}
