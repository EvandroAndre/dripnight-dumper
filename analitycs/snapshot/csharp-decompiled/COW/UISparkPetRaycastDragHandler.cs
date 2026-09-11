using System;
using UnityEngine;

namespace COW;

public class UISparkPetRaycastDragHandler : MonoBehaviour
{
	private UISparkPetAvatarWindowController m_SparkPetAvatarWindowController;

	private UISparkPetAvatar m_SparkPetAvatar;

	private Camera m_Camera;

	public Action OnDragStartCallback;

	public Action OnDragEndCallback;

	public Action OnClickCallback;

	public Action m_OnPositionChangedCallback;

	private bool m_IsDragging;

	private bool m_IsPressed;

	private Vector3 m_PressPosition;

	private Vector3 m_LastMousePosition;

	private float m_PressTime;

	private float m_PressAndHoldDelay;

	private float m_ClickThreshold;

	private int m_TrackedFingerId;

	private bool m_DisabledControlAxesForPress;

	private bool m_HasOriginalMoveAxisEnabled;

	private bool m_OriginalMoveAxisEnabled;

	private bool m_HasOriginalAimAxisEnabled;

	private bool m_OriginalAimAxisEnabled;

	private Bounds m_DragBounds;

	private bool m_HasDragBounds;

	private UIWidget m_BottomMask;

	private UIRoot m_UIRoot;

	private Transform m_SnapTargetTransform;

	private float m_SnapDistanceInUI;

	public void Init(UISparkPetAvatar sparkPetAvatar, Camera camera, UIWidget bottomMask, UISparkPetAvatarWindowController sparkPetAvatarWindowController)
	{
	}

	public void SetupRaycastDragHandler(Action onPositionChangedCallback)
	{
	}

	private void CacheUIRoot()
	{
	}

	private float GetScreenToUIRatio()
	{
		return 0f;
	}

	public void SetPressAndHoldDelay(float delay)
	{
	}

	public void SetSnapTarget(Transform targetTransform, float snapDistance = 50f)
	{
	}

	public void SetDragBounds(Bounds bounds)
	{
	}

	public void SetDragBoundsAuto(float insetX = 0f, float insetY = 0f, uint sparkStage = 0u)
	{
	}

	public Bounds GetDragBoundsAutoWithCollab(UISparkPetAvatar dragAvatar, UISparkPetAvatar followAvatar, float insetX, float insetY, float uiSpacing, bool isModifyMaxX)
	{
		return default(Bounds);
	}

	private void SetBottomMaskWidget(float width, float height)
	{
	}

	private void UpdateBottomMaskPosition()
	{
	}

	private void Update()
	{
	}

	private void UpdateWithTouch()
	{
	}

	private void UpdateWithMouse()
	{
	}

	private bool IsRaycastHitSparkPet(Vector3 screenPosition)
	{
		return false;
	}

	private void OnPressDown(Vector3 screenPosition)
	{
	}

	private void StartDragging()
	{
	}

	private void OnDragMove(Vector3 screenPosition)
	{
	}

	private void OnPressUp(Vector3 screenPosition)
	{
	}

	private void StopDragging()
	{
	}

	private void TrySnapToTarget()
	{
	}

	private void OnClick()
	{
	}

	private void RestoreControlAxesForPress()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
