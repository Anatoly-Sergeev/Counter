using TMPro;
using UnityEngine;

public class CounterRenderer : MonoBehaviour
{
    private const string Title = "Counter: ";

    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.CounterChanged += ShowCounter;
    }

    private void OnDisable()
    {
        _counter.CounterChanged -= ShowCounter;
    }

    private void ShowCounter(int counter)
    {
        _counterText.text = Title + counter;
    }
}
