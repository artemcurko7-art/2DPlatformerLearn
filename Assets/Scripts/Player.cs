using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), (typeof(SpriteRenderer)))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    //[SerializeField] private Direction _direction;
    [SerializeField] private float _speed;

    private readonly int _directionRight = 1;
    private readonly int _directionLeft = -1;

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    public Rigidbody2D Rigidbody2D => _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _playerInput.PressedButtonD += MoveRight;
        _playerInput.PressedButtonA += MoveLeft;
        _playerInput.PressedButtonSpace += Jump;
    }

    private void OnDisable()
    {
        _playerInput.PressedButtonD -= MoveRight;
        _playerInput.PressedButtonA -= MoveLeft;
        _playerInput.PressedButtonSpace -= Jump;
    }

    private void MoveRight() =>
        Move(_directionRight, false);

    private void MoveLeft() =>
        Move(_directionLeft, true);

    private void Move(float direction, bool isFlixX)
    {
        _spriteRenderer.flipX = isFlixX;
        _rigidbody2D.linearVelocity = GetDirection(direction, _speed);
    }

    private void Jump()
    {
        
    }

    private Vector2 GetDirection(float direction, float speed)
    {
        return new Vector2(direction * speed, 0);
    }
}
