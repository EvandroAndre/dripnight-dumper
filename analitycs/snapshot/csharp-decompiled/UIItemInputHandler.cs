using Lean.Touch;
using UnityEngine;

public class UIItemInputHandler : MonoBehaviour
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

	private Vector2 lastTouchPos;

	private Vector2 tempLastTouchPos;

	public bool InputEnable;

	private const string TargetAreaName = "ItemRotateTouchArea";

	private const string PetIgnoreName = "PetIgnoreArea";

	private UIItemRotateType m_CurrentRotateType;

	private Vector3 m_RefencePoint;

	protected bool m_IsRotating;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public void SetRotateType(UIItemRotateType type)
	{
	}

	public void SetRefencePoint(Vector3 point)
	{
	}

	public void SetLastTouchPos(object[] data)
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

	private void RotateItemByOffset(float offsetpos)
	{
	}

	protected virtual void OnRotateEnd()
	{
	}

	public virtual bool IsTargetArea(Vector2 screenPosition)
	{
		return false;
	}

	private void RotatePointItem(Vector3 point, float angle)
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

	public static bool CheckOnPetUIClick()
	{
		return false;
	}

	private bool IsMatchMakingOrRoomHangUpDragging()
	{
		return false;
	}
}
