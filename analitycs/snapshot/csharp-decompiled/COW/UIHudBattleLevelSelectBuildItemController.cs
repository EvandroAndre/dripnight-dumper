using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelSelectBuildItemController : UIBaseController
{
	private const string m_InAnimName = "UIFX_BattleLevel_SelectBuildItemIn";

	private const string m_ExpandAnimName = "UIFX_BattleLevel_SelectBuildItemExpand";

	private const string m_StyleBgInAnimName = "UIFX_BattleLevel_SelectBuildItemBGIn";

	private bool m_IsLocalSelected;

	private Animation m_StyleBgAnim;

	private BattleLevelSelectBuildItemBgStyle m_StyleBgAnimHelper;

	private NKDHFJHPEFL m_BattleLevelModule;

	private UIHudBattleLevelSelectBuildItemView m_View;

	private readonly List<GameObject> m_Clone3PIcon;

	private byte _003CBuildID_003Ek__BackingField;

	public byte BuildID
	{
		get
		{
			return _003CBuildID_003Ek__BackingField;
		}
		private set
		{
			_003CBuildID_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetupBriefAbilities(BattleLevelBuildConfigData battleLevelBuildConfigData)
	{
	}

	private void SetupDetailedAbilities(BattleLevelBuildConfigData battleLevelBuildConfigData)
	{
	}

	private void RefreshLocalSelected(bool selected, bool animated, bool force)
	{
	}

	private void RefreshOtherSelected(int selectCount)
	{
	}

	private void CheckCenterAnimAdjustLayer()
	{
	}

	private void CheckBgStyleAnimAdjustLayer()
	{
	}

	private void PlayInAnim()
	{
	}

	private void PlayStyleBgInAnim()
	{
	}

	private void PlayRefreshAbilitiesAnim(bool selected)
	{
	}

	private void PlayStyleBgRefreshAbilitiesAnim(bool selected)
	{
	}

	private void SampleRefreshAbilitiesAnimLastFrame(bool selected)
	{
	}

	private void SampleStyleBgRefreshAbilitiesAnimLastFrame(bool selected)
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public void SetViewData(byte buildID, bool localSelected, int otherPlayerSelectCount)
	{
	}

	public void SetLocalSelected(bool selected)
	{
	}

	public void SetOtherSelected(int selectCount)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
