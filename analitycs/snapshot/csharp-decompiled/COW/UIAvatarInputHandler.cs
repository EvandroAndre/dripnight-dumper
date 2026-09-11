using Lean.Touch;
using UnityEngine;

namespace COW;

public class UIAvatarInputHandler : MonoBehaviour
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

	public bool UseReference;

	public Vector3 ReferencePoint;

	private float CurrentPanAngle;

	private Vector2 lastTouchPos;

	private Vector2 tempLastTouchPos;

	public bool InputEnable;

	public bool IngoreUICheck;

	private const string TargetAreaName = "AvatarRotateTouchArea";

	private UIMaleAvatar m_avatar;

	private Camera m_InputDetectCamera;

	private bool EnableInHDStandLobby;

	public Camera InputDetectCamera
	{
		private get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetAvatar(UIMaleAvatar ava)
	{
	}

	private bool CheckCanMove()
	{
		return false;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetLastTouchPos(object[] data)
	{
	}

	public void SetUseReference(bool reference, Vector3 point)
	{
	}

	private void FingerSet(LeanFinger finger)
	{
	}

	private void FingerDown(LeanFinger finger)
	{
	}

	private void Update()
	{
	}

	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return false;
	}

	private bool IsMatchMakingOrRoomHangUpDragging()
	{
		return false;
	}

	private void RotateAvatar(float angle, float angledelta = 0f)
	{
	}

	public void ResetPreviewAvatar()
	{
	}

	public void SetAvatarRotation(float rotateY, bool offsetParentY = false)
	{
	}

	public void ResetAvatarRatation(float angle)
	{
	}

	public void ResetAvatarRotation()
	{
	}

	public void ResetAvatarInput()
	{
	}

	public float GetCurrentPanAngle()
	{
		return 0f;
	}

	private bool CheckIsTouchAvatar(Vector2 touchPos)
	{
		return false;
	}

	private void OnTouchAvatar()
	{
	}

	public void FluxWindSet()
	{
	}

	private void LogNotSelfProfileAvatarClick()
	{
	}
}
