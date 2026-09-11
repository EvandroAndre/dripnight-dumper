using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UIAchievementTipsBoxController : UIBaseController
{
	public enum ETipsBoxType
	{
		None,
		Achievement,
		RankUp
	}

	private UIAchievementTipsBoxView m_View;

	private UIModelAchievement m_ModelAchievement;

	private float m_CurrentExpireTime;

	private bool m_HasExpired;

	private uint m_AchievementID;

	private List<uint> m_CompletedAndUnpopedEntryIDList;

	private Queue<AchievementInfo> m_AchievementInfosQueue;

	private float m_AnimTime;

	private float m_RankAnimTime;

	private int m_PopupNum;

	private bool m_IsBlockTipBoxUpdate;

	private ETipsBoxType m_BoxType;

	private bool m_AchievementTipsHasDone;

	private bool m_HasData;

	private UIBaseProfileInfoController m_FriendInfoCtrl;

	private List<Type> m_PopupWindowType;

	private List<Type> m_NavigationType;

	private GameObject m_GlowEffect;

	private uint m_UIFXType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void AddInfoToQueue(ETipsBoxType type, int preRank = 0, int curRank = 0, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_NONE)
	{
	}

	private int CompareFriendListCsRankInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	private int CompareFriendListRankInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	public void SetRankInfo(int preRank, int curRank, DLBMPCCFKKM matchMode)
	{
	}

	private bool CheckShowAchievement()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void CheckClose()
	{
	}

	private void Update()
	{
	}

	private void InitInfoByTipsType(AchievementInfo info)
	{
	}

	private void UpdateAchievement()
	{
	}

	private void CheckCanPopup()
	{
	}

	public void CheckAchievementList()
	{
	}

	public void SetUIData(AchievementEntryDesc desc, ulong time)
	{
	}

	public void OnTipsBoxClose()
	{
	}

	private void GotoAchievementMainPage()
	{
	}

	private void SetAchievementUIFX(AchievementEntryDesc desc)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
