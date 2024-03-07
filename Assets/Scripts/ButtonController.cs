using System;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private List<ButtonActivator> _buttons;

    public Action OnTapped;

    private void Awake()
    {
        foreach (var button in _buttons) button.OnTapped += () => OnTapped?.Invoke();
    }
}