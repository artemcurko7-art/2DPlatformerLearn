using UnityEngine;

public class PlayerRotation : UnitRotation
{
    private readonly int _numberHorizontalX = 1;

    public Quaternion GetRotation(float horizontal) =>
        horizontal == _numberHorizontalX ? RotationLookRight : RotationLookLeft;
}
