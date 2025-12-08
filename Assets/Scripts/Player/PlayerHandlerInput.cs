using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandlerInput : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerJump _playerJump;

    //private void OnEnable()
    //{
    //    _playerInput.Movable += _playerMovement.Move;
    //    _playerInput.Jumped += _playerJump.Jump;
    //}

    //private void OnDisable()
    //{
    //    _playerInput.Movable -= _playerMovement.Move;
    //    _playerInput.Jumped -= _playerJump.Jump;
    //}
}
