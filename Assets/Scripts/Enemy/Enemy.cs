using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), (typeof(SpriteRenderer)))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyPatrolling _enemyPatrolling;

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _enemyPatrolling.Move();
    }
}
