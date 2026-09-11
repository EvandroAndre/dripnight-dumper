using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelSelectBuildDetailedAbilityController : UIBaseController
{
	private const int m_DefaultSizeAbilityDescWidth = 170;

	private const int m_LargeSizeAbilityDescWidth = 200;

	private const float m_FilledCenterWidgetAlpha = 1f;

	private const float m_EmptyCenterWidgetAlpha = 0.5f;

	private UIHudBattleLevelSelectBuildDetailedAbilityView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(BattleLevelAbilityConfigData abilityConfigData, bool filled, bool largeSizeDesc)
	{
	}

	public Vector3 GetNodePosition()
	{
		return default(Vector3);
	}

	public float GetLocalPositionY()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
