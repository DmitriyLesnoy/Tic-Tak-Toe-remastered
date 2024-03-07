using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActivator : MonoBehaviour
{
    [SerializeField] TurnController _controller;
    [SerializeField] Image _image;
    [SerializeField] Button _button;

    public Action OnTapped;

    public void Activate()
    {
        _image.sprite = _controller.CurrentTurnSprite;
        _image.color = new Color(1, 1, 1, 1);
        OnTapped?.Invoke();
        _button.enabled = false;
        enabled = false;
    }
}