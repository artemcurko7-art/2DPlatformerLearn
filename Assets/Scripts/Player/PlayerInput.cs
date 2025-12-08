using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action Movable;
    public event Action Jumped;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
            Movable?.Invoke();

        if (Input.GetKeyDown(KeyCode.Space))
            Jumped?.Invoke();
    }
}
