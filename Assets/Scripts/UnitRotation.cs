using UnityEngine;

public abstract class UnitRotation : MonoBehaviour
{
    protected readonly Quaternion RotationLookRight = Quaternion.identity;
    protected readonly Quaternion RotationLookLeft = Quaternion.Euler(0, 180, 0);
}
