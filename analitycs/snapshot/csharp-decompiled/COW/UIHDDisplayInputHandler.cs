using Lean.Touch;
using UnityEngine;

namespace COW;

public class UIHDDisplayInputHandler : MonoBehaviour
{
	private enum MouseButton
	{
		Left,
		Right,
		Middle,
		None
	}

	public enum ERotateAxis
	{
		X,
		Y,
		Z
	}

	public float PanMovementSensitivity;

	public float RotateSensitivity;

	public float CurrentPanAngle;

	private Vector2 lastTouchPos;

	private UIHDStandLobbyManager.HDLobbyState m_LobbyState;

	private bool m_AutoRotateSwitchOn;

	private float m_AutoRotateSpeed;

	private ERotateAxis m_RotateAxis;

	private bool m_AutoRotateOn;

	private bool m_IsFingerDown;

	public void SetData(UIHDStandLobbyManager.HDLobbyState lobbyState, bool autoRotateSwitchOn, bool autoRotateOn, float autoRotateSpeed, ERotateAxis axis)
	{
	}

	private void OnDisplayObjectAutoRotateChanged(object[] data)
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

	private void FingerUp(LeanFinger finger)
	{
	}

	private void Update()
	{
	}

	private void AutoRotateOneFrame()
	{
	}

	public void SaveCurrentPanAngle(float angle)
	{
	}

	private void RotateItem()
	{
	}

	public bool CheckOnUIClick()
	{
		return false;
	}
}
