using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private const float Delay = 0.5f;
    private const int Step = 1;

    private WaitForSeconds _wait;
    private int _counter;
    private bool _canCount;

    [SerializeField] private InputReader _input;

    public event Action<int> CounterChanged; 

    private void OnEnable()
    {
        _input.WorkStateSwitched += SwitchWorkState;
    }

    private void OnDisable()
    {
        _input.WorkStateSwitched -= SwitchWorkState;
    }

    private void Start()
    {
        _counter = 0;
        _canCount = false;
        _wait = new(Delay);
    }

    private void SwitchWorkState()
    {
        if (_canCount)
        {
            _canCount = false;
        }
        else
        {
            _canCount = true;
            StartCoroutine(IncrementCounter());
        }
    }

    private IEnumerator IncrementCounter()
    {
        while (_canCount)
        {
            _counter += Step;
            CounterChanged?.Invoke(_counter);

            yield return _wait;
        }
    }
}
