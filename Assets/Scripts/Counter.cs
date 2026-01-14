using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Counter : MonoBehaviour
{
    private const string Title = "Counter: ";
    private const float Delay = 0.5f;
    private const int Step = 1;

    [SerializeField] private TextMeshProUGUI _counterText;

    private WaitForSeconds _wait;
    private int _counter;
    private bool _canCount;

    private void Start()
    {
        _counter = 0;
        _counterText.text = Title + _counter;
        _canCount = false;
        _wait = new(Delay);
    }

    private void OnMouseDown()
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
            _counterText.text = Title + _counter;

            yield return _wait;
        }
    }
}
