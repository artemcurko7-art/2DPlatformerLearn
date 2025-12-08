using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Player _player;
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

    public void Move()
    {
        if (_playerJump.IsGrounded())
        {
            _player.Animator.SetBool(IsRun, true);
            _player.SpriteRenderer.flipX = IsChangeFlip();
            _player.Rigidbody2D.linearVelocity = GetDirection(Horizontal, _speed);
        }
    }

    private Vector2 GetDirection(float direction, float speed) =>
        new Vector2(direction * speed, 0);

    private bool IsChangeFlip() =>
        Horizontal == _numberHorizontalX;   
}
