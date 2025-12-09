using UnityEngine;

public class UnitRotation : MonoBehaviour
{
    private readonly Quaternion _rotationLookRight = Quaternion.identity;
    private readonly Quaternion _rotationLookLeft = Quaternion.Euler(0, 180, 0);
    private readonly int _numberHorizontalX = 1;

    public Quaternion GetRotation(float direction) =>
        direction == _numberHorizontalX ? _rotationLookRight : _rotationLookLeft;
}
