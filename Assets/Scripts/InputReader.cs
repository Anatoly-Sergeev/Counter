using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int LeftMouseButton = 0;
    private const int RightMouseButton = 1;
    private const int MiddleMouseButton = 2;

    public event Action WorkStateSwitched;

    private void Update()
    {
        GetMouseClick();
    }

    private void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton) || Input.GetMouseButtonDown(RightMouseButton) || Input.GetMouseButtonDown(MiddleMouseButton))
            WorkStateSwitched?.Invoke();
    }
}
