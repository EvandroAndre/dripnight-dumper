using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIGroupRecruitHeadItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIPopupMessageBoxController mesBoxCtrl;

		internal void _003COnJoinBtnClick_003Eb__1()
		{
		}
	}

	private UIGroupRecruitHeadItemView m_View;

	private GroupRecruitTeamMemberInfo m_MemInfo;

	private ulong m_GroupId;

	private string m_RecruitCode;

	private uint m_MatchMode;

	private bool m_HasMapBonus;

	private float m_GrandMasterRankScale;

	private Vector3 m_DefaultRankScale;

	private UIBRRankIconController m_BRRankIconController;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnHeadBtnClick()
	{
	}

	private void OnJoinBtnClick()
	{
	}

	public void SetView(GroupRecruitTeamMemberInfo memberInfo, EGameModeCategory gameModeCategory = EGameModeCategory.BattleRoyale, ulong groupId = 0uL, uint matchMode = 0u, string recruitCode = "", bool needShrink = false, bool hasMapBonus = false)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void SetBRRankIcon(int rank, int peakRankPos)
	{
	}

	private void SetCSRankIcon(int rank, int peakRankPos)
	{
	}

	private void SetCSPeakTournamentRankIcon(GroupRecruitTeamMemberInfo memberInfo)
	{
	}

	private void SetHeadView(EGameModeCategory gameModeCategory = EGameModeCategory.BattleRoyale)
	{
	}

	private bool CheckMapBonus()
	{
		return false;
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void TrySetPrivilegeIcon(GroupRecruitTeamMemberInfo memberInfo)
	{
	}

	private void _003COnJoinBtnClick_003Eb__16_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
