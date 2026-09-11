using System.Collections.Generic;
using Lean.Touch;
using UnityEngine;

namespace COW;

public class PreviewInputHandler : MonoBehaviour
{
	private enum MouseButton
	{
		Left,
		Right,
		Middle,
		None
	}

	private float RotateSensitivity;

	private float CurrentPanAngle;

	private Vector2 lastTouchPos;

	private bool InputEnable;

	public List<GameObject> m_PreviewTransList;

	public void SetPreviewInputEnable(bool flag)
	{
	}

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

	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return false;
	}

	private void RotateList(float angle, float angledelta = 0f)
	{
	}

	private void Update()
	{
	}
}
