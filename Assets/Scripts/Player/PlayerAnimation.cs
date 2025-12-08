using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Player _player;

    private readonly string _run = "IsRun";

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _player.Idled += OnIdledAnimation;
        _player.Movable += OnMovableAnimation;
    }

    private void OnDisable()
    {
        _player.Idled -= OnIdledAnimation;
        _player.Movable -= OnMovableAnimation;
    }

    private void OnIdledAnimation() =>
        _animator.SetBool(_run, false);

    private void OnMovableAnimation() =>
        _animator.SetBool(_run, true);
}