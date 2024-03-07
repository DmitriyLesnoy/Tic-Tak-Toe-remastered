using UnityEngine;

public class TurnController : MonoBehaviour
{
    public int CurrentTurnSide { get => _currentTurnSide; }
    public Sprite CurrentTurnSprite
    {
        get
        {
            if (_currentTurnSide == 1) return _crossSprite;
            return _circleSprite;
        }
    }

    [SerializeField] private ButtonController _controller;
    [SerializeField] private Sprite _crossSprite;
    [SerializeField] private Sprite _circleSprite;

    private int _currentTurnSide = 1;

    private void Awake() => _controller.OnTapped += ChangeTurnSide;

    private void ChangeTurnSide()
    {
        _currentTurnSide = 1 - _currentTurnSide;
    }
}