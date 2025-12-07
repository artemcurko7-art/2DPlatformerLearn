using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action PressedButtonD;
    public event Action PressedButtonA;
    public event Action PressedButtonSpace;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            PressedButtonD?.Invoke();
        else if (Input.GetKey(KeyCode.A))
            PressedButtonA?.Invoke();

        if (Input.GetKey(KeyCode.S))
            PressedButtonSpace?.Invoke();
    }
}
