using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private PlayerWallet _playerWallet;
    [SerializeField] private PlayerRotation _playerRotation;

    public event Action Movable;
    public event Action Idled;

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            Movable?.Invoke();
            _playerMovement.Move(_rigidbody2D);
            transform.rotation = _playerRotation.GetRotation(_playerMovement.Horizontal);
        }
        else
        {
            Idled?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Space))
            _playerJump.Jump(_rigidbody2D);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.TryGetComponent<Coin>(out Coin coin))
        {
            _playerWallet.AddCoin(coin);
        }
    }
}
