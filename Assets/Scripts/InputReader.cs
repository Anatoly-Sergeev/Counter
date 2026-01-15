using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public event Action WorkStateSwitched;

    private void Update()
    {
        GetMouseClick();
    }

    private void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
            WorkStateSwitched?.Invoke();
    }
}
