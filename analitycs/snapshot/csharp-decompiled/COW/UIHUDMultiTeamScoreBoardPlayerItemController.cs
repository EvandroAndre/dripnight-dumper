using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDMultiTeamScoreBoardPlayerItemController : UIBaseController
{
	private UIHUDMultiTeamLeaderboard_TeammateItemView m_View;

	private UIHUDTeamBattleScoreBoardSkillController m_KDAPanelSkillCtrl;

	protected HBLKLJHFJDK m_ActiveSkill;

	protected AvatarSkillData m_SamoActiveSkillData;

	private TeamScoreBoardData m_Data;

	private List<int> m_ScoreTypes;

	private Dictionary<int, UILabel> m_LabelDict;

	protected Player m_Player;

	private bool hasReported;

	private bool m_IsSelf;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	public TeamScoreBoardData DataInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnClickReportBtn()
	{
	}

	public void SetViewData(List<int> scoreTypes)
	{
	}

	private void SetScoreTypeLabels(List<int> scoreTypes, Transform labelRoot, GameObject LabelTemp, Dictionary<int, UILabel> uilabels)
	{
	}

	protected virtual void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	public void SetPlayer(Player player)
	{
	}

	protected virtual void SetSelf(bool isSelf)
	{
	}

	public void ShowReportButton(bool show)
	{
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	public void RefreshData(Player player, int infoType)
	{
	}

	private void UpdateInfoData(UILabel infoTxt, Player player, int index)
	{
	}

	private void OnKDChange(int kill, int dead)
	{
	}

	private void OnAssistCountChange(int assistCount)
	{
	}

	protected virtual void OnKillChange(int kill)
	{
	}

	protected virtual void OnDeadChange(int dead)
	{
	}

	protected virtual void OnDamageChange(uint damage)
	{
	}

	protected virtual void OnFootballScoreChange(int goal)
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	private void InitSkill()
	{
	}

	protected void SetSkillData(Player player)
	{
	}

	protected void UpdatePlayerActiveSkillData(Player player)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
