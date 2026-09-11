using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIMatchResultProfileInfoController : UIBaseController
{
	private UIMatchResultProfileInfoView m_View;

	private uint m_DelayCall;

	private List<uint> m_battleTags;

	private int count;

	private float m_showTimeStamp;

	private float m_showTimeInterval;

	private string moveAnim;

	private int index;

	private bool m_ActiveAnim;

	private UILeaderBoardTitleSingleController m_LeaderBoardTitleCtrl;

	private bool m_showMvp;

	private int width;

	private Vector3 scrollViewLocalPosition;

	private List<MacthAchievementItem> mlistMacthAchievementItems;

	private UITitleCommonController m_TitleCommonCtrl;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private int PLAYER_NAME_WIDTH;

	private uint mDelayKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void SetData(UIHudResultShowBaseController.AvatarProfileInfo data, MatchStats matchStats)
	{
	}

	private void RefreshRatingUI(UIHudResultShowBaseController.AvatarProfileInfo data, MatchStats matchStats)
	{
	}

	private void RefreshContentLabelColor(float alpha)
	{
	}

	private void ShowWeaponPowerInfo(LeaderBoardTitleShowingParams showParams)
	{
	}

	public void ShowMVPFlag(bool isWin)
	{
	}

	public void ShowMatchAchievement(uint[] achievements)
	{
	}

	public void SetIsSelf()
	{
	}

	private void SetWeaponPowerVFXVisibility(object[] data)
	{
	}

	public void ActiveBattleTagsAnim(object[] param)
	{
	}

	private void SetTitleShow(uint titleId)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
