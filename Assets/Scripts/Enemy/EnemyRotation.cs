using UnityEngine;

public class EnemyRotation : UnitRotation
{
    public Quaternion GetRotation() =>
        transform.rotation == RotationLookRight ? RotationLookLeft : RotationLookRight;
}
