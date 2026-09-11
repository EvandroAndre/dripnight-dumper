using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleStyleDetailedAbilityController : UIBaseController
{
	private const int m_DefaultSizeAbilityDescWidth = 170;

	private const int m_LargeSizeAbilityDescWidth = 200;

	private UIHudBattleStyleDetailedAbilityView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(BattleStyleLoadoutLevelData abilityConfigData, bool filled, bool largeSizeDesc)
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

	public int GetNodeHeight()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
