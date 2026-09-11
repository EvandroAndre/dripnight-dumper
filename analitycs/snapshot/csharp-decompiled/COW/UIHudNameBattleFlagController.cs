using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNameBattleFlagController : UIHudNameBaseController
{
	private LevelBattleFlag bindedLevelObject;

	private BattleFlagConfigData m_ConfigData;

	private UIHudNameBattleFlagView m_View;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindLevelObject(LevelBattleFlag battle_flag)
	{
	}

	public void ClearBind()
	{
	}

	private void RefreshName()
	{
	}

	private void RefreshClanName()
	{
	}

	private void RefreshBRRank()
	{
	}

	private void RefreshCSRank()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool IsVisibleWithZoneType(int zonetype)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsVisibleWithZoneType(int P0)
	{
		return false;
	}
}
