using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UILoadingPlayerInfoController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UILoadingPlayerInfoController _003C_003E4__this;

		public GameObject nextShowObj;

		public GameObject showObj;

		internal void _003CAlternatingDisplayTitle_003Eb__0()
		{
		}
	}

	private UILoadingPlayerInfoView m_View;

	private List<UILoadingPlayerInfoItemController> m_InfoItemCtrls;

	private GameObject m_EliteVFX;

	private const int COUNT_BATTLE_TAG = 2;

	private List<UISprite> m_ListPassiveSkillSprites;

	private UIModelProfile m_ModelProfile;

	private UIModelCollection m_ModelCollection;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelNewVault m_ModelNewVault;

	private UIModelUser m_ModelUser;

	private UIModelInventory m_ModelInvetory;

	private bool m_CurBattleCardUIShow;

	private ELoadingBattleType m_BattleCardType;

	private uint m_DelayShow;

	private UILaunchTagFrameController m_LaunchTag;

	private VisualInstanceHolder m_PrivilegeVFXHolder;

	private int m_NickNameOriginWidth;

	private int OFFSET_PRIVILEGE;

	private UICSPeakInfoItemController m_CSPeakInfoCtrl;

	private Dictionary<int, Color> m_IndexColorTop;

	private Dictionary<int, Color> m_IndexColorBottom;

	private UITitleCommonController titleCtrl;

	public void SetView(UILoadingPlayerInfoView view, LoadingCardShowPage showPage = LoadingCardShowPage.Loading, int index = 0)
	{
	}

	public void SetViewDataByTcpNtf(ELoadingBattleType loadingBattleType, MatchPregameInfo info, int index)
	{
	}

	private void SetOccupationView(List<AccountOccupationData> infos, ELoadingBattleType type)
	{
	}

	public void SetHeadIconAndNickName(uint headIconId, string nickName, ulong accountId, tcp.PrimePrivilegeDetail primeInfo)
	{
	}

	public void RefreshPrivilegeIcon(BadgeInfoInGame badgeInfo, bool showBadgeConsiderMatchMode = true, proto.ECreditScore.SummaryLevel periodicSummaryLevel = proto.ECreditScore.SummaryLevel.SummaryLevel_NOT_INIT)
	{
	}

	public void RefreshSelfPrivilegeIcon()
	{
	}

	public void SetHeadIconAndNickName(uint headIconId, string nickName, ulong accountId, proto.PrimePrivilegeDetail primeInfo)
	{
	}

	public void SetRank(ELoadingBattleType loadingBattleType, uint rank, uint rankingPoints, uint[] heroicSeasons)
	{
	}

	public void SetCharacter(uint avatarId)
	{
	}

	public void SetInfoData(ELoadingBattleType loadingBattleType, uint[] infoArray, BattleStatsInfo statsInfo = null, bool ignoreDefault = false, bool showPlaceHolder = false, bool showRefreshAnim = false)
	{
	}

	private void PrepareInfoItems()
	{
	}

	private void InitBg()
	{
	}

	private void PrepareSkills()
	{
	}

	public void RefreshSkill(uint[] skills)
	{
	}

	public void RefreshTeamIndex(int index)
	{
	}

	public void RefreshTitlAndBg(uint titleId)
	{
	}

	public void RefreshLeaderBoardTitle(MatchPregameInfo preGameInfo)
	{
	}

	private void OpenUILeaderBoardTitleCommonCtrl(LeaderBoardTitleShowingParams showParams)
	{
	}

	public void RefreshTeamIndexBg()
	{
	}

	public void ChangeBattleCardUIState()
	{
	}

	public bool GetBattleCardUIState()
	{
		return false;
	}

	public void RefreshBattleCardUIInFrontEndPreview(uint cardId, LoadingCardShowPage showPage = LoadingCardShowPage.FrontEndPreview, int maxDepth = 0)
	{
	}

	public void RefreshtOccpation()
	{
	}

	private void RefreshBattleCardInfo(ELoadingBattleType loadingBattleType, List<uint> listLoadingPregameInfo, BattleStatsInfo statsInfo)
	{
	}

	public void RefreshInfo()
	{
	}

	private void AlternatingDisplayTitle(GameObject showObj, GameObject nextShowObj)
	{
	}

	public void RefreshLoadingCard(uint cardId, uint loadingAvatar = 0u, LoadingCardShowPage page = LoadingCardShowPage.FrontEndPreview, int maxDepth = 0)
	{
	}

	public void RefreshCSPeakDecoByBattleType(ELoadingBattleType loadingBattleType)
	{
	}

	private void PrepareCSPeakInfoItems()
	{
	}

	public void SetWeaponIcon(uint weaponId, bool isSelfCard = true)
	{
	}

	public void SetCSPeakInfoData(uint[] infoArray, BattleStatsInfo statsInfo = null, bool showRefreshAnim = false, bool isSelfCard = true)
	{
	}

	private void SetCSPeakInfoSubInfo(uint subInfoItem, BattleStatsInfo statsInfo)
	{
	}

	public void ShowLaunchTagInLoading(uint cardId, uint serialNumber, bool isForceHide = false)
	{
	}

	public void ShowLaunchTagInFrontEndScene(uint cardID)
	{
	}

	private void ShowLaunchTag(uint tagID, uint serialNumber)
	{
	}

	private void HideLaunchTag()
	{
	}

	private void SetPrivilegeIcon(uint badgeType, uint subType)
	{
	}

	private void SetExcellentBehaviorIcon()
	{
	}

	private void SetPrivilegeVFX(uint badgeType, uint subType)
	{
	}

	private void TryReleasePrivilegeVFXHolder()
	{
	}

	private void OnDestroy()
	{
	}
}
