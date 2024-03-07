using UnityEngine;

public class WinScreenActivator : MonoBehaviour
{
	[SerializeField] private CanvasGroup _group;

	private bool _isStarted = false;

	private void Update()
	{
		if (_isStarted) _group.alpha += Time.deltaTime;
		if (_group.alpha >= 1) enabled = false;
	}

	public void Activate()
	{
		_group.blocksRaycasts = true;
		_isStarted = true;
	}
}