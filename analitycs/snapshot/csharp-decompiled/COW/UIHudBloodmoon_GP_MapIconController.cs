using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudBloodmoon_GP_MapIconController : UIBaseController
{
	private const float BaseCircleDiameter = 100f;

	private UIHudBloodmoon_GP_MapIconView m_View;

	private float m_CooldownEndServerTimeSec;

	private int m_LastCooldownSeconds;

	private bool m_IsCooldown;

	private bool m_IsTaskAccepted;

	private float m_CircleGeoScale;

	private Vector3 m_MapIconScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetRangeRadius(float radius)
	{
	}

	public void SetCooldown(float remainingSeconds)
	{
	}

	public void SetTaskAccepted(bool isTaskAccepted)
	{
	}

	private void Update()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public void UpdateBloodmoonGPIconRotation(Quaternion rotation)
	{
	}

	public void UpdateBloodmoonGPIconScale(Vector3 mapIconScale)
	{
	}

	private void ApplyCircleContainerScale()
	{
	}

	public float GetCenterIconHalfExtent()
	{
		return 0f;
	}

	private UISprite GetActiveCenterIconSprite()
	{
		return null;
	}

	private void RefreshCooldown(bool force)
	{
	}

	private void RefreshIconState()
	{
	}

	private static string FormatCooldown(int totalSeconds)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
