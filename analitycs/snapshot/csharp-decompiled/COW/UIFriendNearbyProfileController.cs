using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendNearbyProfileController : UIBaseController
{
	private enum IconType
	{
		None,
		CSPeak,
		BRRank,
		CSRank,
		Occupation,
		UGCLevel
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__37_1;

		public static Action _003C_003E9__37_3;

		internal void _003CJoinPlayerGroup_003Eb__37_1()
		{
		}

		internal void _003CJoinPlayerGroup_003Eb__37_3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public UIFriendNearbyProfileController _003C_003E4__this;

		public int index;

		internal void _003CSetupButtonHover_003Eb__0(GameObject go)
		{
		}
	}

	private UIFriendNearbyProfileView m_View;

	private const float ICON_SCALE_CSPEAK = 0.2f;

	private const float ICON_SCALE_STANDARD = 0.52f;

	private const float ICON_SCALE_Occupation = 0.42f;

	private const float ICON_SCALE_UGC = 0.39f;

	private static readonly Vector3 ICON_OFFSET_Occupation;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelFriends.NearbyPlayerInfo m_PlayerData;

	private UIModelFriends m_ModelFriends;

	private UIModelGroup m_ModelGroup;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelProfile m_ModelProfile;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	private IconType[] m_IconTypes;

	private UIButton[] m_DetailButtons;

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

	public void SetPlayerData(UIModelFriends.NearbyPlayerInfo playerData)
	{
	}

	public void ClearPlayerData()
	{
	}

	public void CloseDetailTips()
	{
	}

	private void RefreshUI()
	{
	}

	private void UpdateProfileInfo()
	{
	}

	private void UpdateDistanceInfo()
	{
	}

	private void UpdateButtons()
	{
	}

	private void OnInviteBtnClick()
	{
	}

	private void ClickInviteFriend()
	{
	}

	public void OnAddFriendBtnClick(bool suppressTips = false)
	{
	}

	private void OnHeadBtnClick()
	{
	}

	private bool IsPlayerInGroup()
	{
		return false;
	}

	private void InitCreateGroupToInviteData()
	{
	}

	private void InviteFriend()
	{
	}

	private void JoinPlayerGroup()
	{
	}

	private void UpdatePlayerNameIcons()
	{
	}

	private void ApplyIconOffsets()
	{
	}

	private void ClearPlayerNameIcons()
	{
	}

	private bool ShouldShowCSPeakIcon()
	{
		return false;
	}

	private bool ShouldShowBRRankIcon()
	{
		return false;
	}

	private bool ShouldShowCSRankIcon()
	{
		return false;
	}

	private bool ShouldShowOccupationIcon()
	{
		return false;
	}

	private bool ShouldShowUGCLevelIcon()
	{
		return false;
	}

	private void AddCSPeakIcon(GameObject container)
	{
	}

	private void AddBRRankIcon(GameObject container)
	{
	}

	private void AddCSRankIcon(GameObject container)
	{
	}

	private uint GetOccupationId()
	{
		return 0u;
	}

	private uint GetOccupationLevel(uint occupationId)
	{
		return 0u;
	}

	private void AddOccupationIcon(GameObject container)
	{
	}

	private uint GetUGCLevel()
	{
		return 0u;
	}

	private void AddUGCLevelIcon(GameObject container)
	{
	}

	private UISprite GetIconSprite(GameObject container)
	{
		return null;
	}

	private void SetupDetailButtonHoverActions()
	{
	}

	private void SetupButtonHover(UIButton button, int index)
	{
	}

	private void OnDetailButtonClick(int index)
	{
	}

	private List<IconTextData> BuildIconTextDataList()
	{
		return null;
	}

	private UIButton GetButtonByIndex(int index)
	{
		return null;
	}

	private string GetIconTipText(int index)
	{
		return null;
	}

	private string GetAllIconsTipText()
	{
		return null;
	}

	private string GetBRRankName()
	{
		return null;
	}

	private string GetCSRankName()
	{
		return null;
	}

	private string GetOccupationName(uint occupationId)
	{
		return null;
	}

	private void _003COnUIInit_003Eb__21_0()
	{
	}

	private void _003CJoinPlayerGroup_003Eb__37_0()
	{
	}

	private void _003CJoinPlayerGroup_003Eb__37_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
