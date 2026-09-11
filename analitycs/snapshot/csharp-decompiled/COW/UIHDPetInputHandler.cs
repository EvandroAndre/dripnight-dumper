using Lean.Touch;
using UnityEngine;

namespace COW;

public class UIHDPetInputHandler : MonoBehaviour
{
	private enum MouseButton
	{
		Left,
		Right,
		Middle,
		None
	}

	public float PanMovementSensitivity;

	public float RotateSensitivity;

	private float CurrentPanAngle;

	private bool m_isTouched;

	private Vector2 lastTouchPos;

	private Vector2 tempLastTouchPos;

	public bool InputEnable;

	private const string TargetAreaName = "ItemRotateTouchArea";

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void FingerSet(LeanFinger finger)
	{
	}

	private void FingerDown(LeanFinger finger)
	{
	}

	private void FingerUp(LeanFinger finger)
	{
	}

	private void Update()
	{
	}

	public bool IsTargetArea(Vector2 screenPosition)
	{
		return false;
	}

	private void RotateItem()
	{
	}

	public float GetCurrentPanAngle()
	{
		return 0f;
	}

	public void ResetPetRatation(float angle)
	{
	}

	public void EnableInput(bool v)
	{
	}

	public void ResetPetInput()
	{
	}

	public bool CheckOnUIClick()
	{
		return false;
	}
}
