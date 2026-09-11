using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHUDUGC_TwoTeamResultController : UIHudUGCTeamBattleMatchResultController, IUIHUDBaseController
{
	private UGCTwoTeamMatchResultHudRepItem m_ViewData;

	private string m_EntityID;

	protected Dictionary<UIPanel, int> m_PanelDepth;

	private UGCInternalHudRepItem m_UGCInternalHudRepItem;

	private bool m_MatchEnd;

	private bool needRefreshPlayerList;

	private uint rightTeamIndex;

	private string rightFactionID;

	private uint leftTeamIndex;

	private string leftFactionID;

	private List<Player> playerList;

	private List<object> winMVPList;

	private List<object> loseMVPList;

	private List<object> score3List;

	private List<object> score2List;

	private List<object> score1List;

	public static bool SHOW_REPORT;

	private bool _showReplay;

	public static bool SHOW_LIKE;

	public static bool SHOW_ADD_FRIEND;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void DestroyEntity()
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	public void SetEntityID(string entityID)
	{
	}

	private void OnDepthChanged(int cur)
	{
	}

	private void OnResultChanged(int obj)
	{
	}

	protected override bool UseLongTeamList()
	{
		return false;
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void OnRightTeamChanged(string obj)
	{
	}

	private void OnLeftTeamChanged(string obj)
	{
	}

	private void OnPlayerChanged(List<object> obj)
	{
	}

	private bool IsOnLeftSide(Player p)
	{
		return false;
	}

	private void RefreshPlayerList()
	{
	}

	private void OnWinMVPChanged(List<object> obj)
	{
	}

	private void OnLoseMVPChanged(List<object> obj)
	{
	}

	private bool IsMVP(BHGGAEEHJCO playerID, out bool isWin)
	{
		isWin = default(bool);
		return false;
	}

	private void OnScore3Changed(List<object> obj)
	{
	}

	private void OnScore2Changed(List<object> obj)
	{
	}

	private void OnScore1Changed(List<object> obj)
	{
	}

	private void OnTitleListChanged(List<object> obj)
	{
	}

	private void OnRightTeamScoreChanged(string obj)
	{
	}

	private void OnLeftTeamScoreChanged(string obj)
	{
	}

	private void OnRightTeamNameChanged(string obj)
	{
	}

	private void OnLeftTeamNameChanged(string obj)
	{
	}

	private void OnShowShareChanged(bool obj)
	{
	}

	private void OnShowReportChanged(bool obj)
	{
	}

	private void OnShowReplayChanged(bool obj)
	{
	}

	protected override bool IsShowReplayBtn()
	{
		return false;
	}

	private void OnShowLobbyChanged(bool obj)
	{
	}

	private void OnShowLikeChanged(bool obj)
	{
	}

	private void OnShowEcconomyChanged(bool obj)
	{
	}

	private void OnShowFriendChanged(bool obj)
	{
	}

	private void OnShowGiftChanged(bool obj)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	private void OnShowMapEvaluateChanged(bool cur)
	{
	}

	protected override void OnClickNextBtn()
	{
	}

	protected override void RefreshBtnState()
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_UseLongTeamList()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsShowReplayBtn()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnClickNextBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshBtnState()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}
}
