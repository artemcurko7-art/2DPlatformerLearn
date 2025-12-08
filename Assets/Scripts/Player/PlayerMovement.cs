using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private float _speed;

    public readonly string IsRun = "IsRun";
    private readonly string _horizontal = "Horizontal";
    private readonly int _numberHorizontalX = -1;

    public float Horizontal { get; private set; }

    private void Update()
    {
        Horizontal = Input.GetAxis(_horizontal);
    }

    public void Move(Rigidbody2D rigidbody2D)
    {
        if (_playerJump.IsGrounded())
        {
            rigidbody2D.linearVelocity = GetDirection(Horizontal, _speed);
        }
    }

    private Vector2 GetDirection(float direction, float speed) =>
        new Vector2(direction * speed, 0);
}
