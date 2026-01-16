using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int MouseButton = 0;

    public event Action WorkStateSwitched;

    private void Update()
    {
        GetMouseClick();
    }

    private void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(MouseButton))
            WorkStateSwitched?.Invoke();
    }
}
