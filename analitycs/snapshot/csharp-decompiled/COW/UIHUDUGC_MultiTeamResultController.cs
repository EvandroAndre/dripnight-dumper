using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHUDUGC_MultiTeamResultController : UIHudMatchResultBaseController, IEasyList, IUIHUDBaseController
{
	private UIHUDUGC_MultiTeamResultView m_View;

	private UGCMultiTeamMatchResultHudRepItem m_ViewData;

	private string m_EntityID;

	private const int MAX_COL = 5;

	protected Dictionary<UIPanel, int> m_PanelDepth;

	private UGCInternalHudRepItem m_UGCInternalHudRepItem;

	private List<string> EntityList;

	private bool arrangedByFaction;

	private List<Player> PlayerList;

	private List<object> rankDisplayList;

	private string mainScoreTitle;

	private List<object> mainScoreList;

	private List<object> winMVPList;

	private List<object> loseMVPList;

	private Dictionary<int, List<object>> scoreDic;

	private List<object> titleList;

	public static bool showReport;

	private bool _showReplay;

	public static bool showLike;

	public static bool showAddFriend;

	private List<UIHUDUGC_MultiTeamResultTeamItemController> teamItemList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	public void DestroyEntity()
	{
	}

	public void SetEntityID(string entityID)
	{
	}

	private void OnTeamRankChanged(List<object> obj)
	{
	}

	private void OnPlayerChanged(List<object> obj)
	{
	}

	private void OnDepthChanged(int cur)
	{
	}

	private bool IsInThisTeamOrFaction(Player p, string entityId)
	{
		return false;
	}

	private void RefreshPlayerList()
	{
	}

	private void RefreshAllItem()
	{
	}

	private ulong GetAccountIDByName(string nick)
	{
		return 0uL;
	}

	private void OnRank4DisplayChanged(List<object> obj)
	{
	}

	private void UpdateRankDisplay()
	{
	}

	private void OnResultChanged(int obj)
	{
	}

	private void OnTitle2Changed(string obj)
	{
	}

	private void OnTitle1Changed(string obj)
	{
	}

	private void OnMainScoreTitleChanged(string obj)
	{
	}

	private void OnMainScoreListChanged(List<object> obj)
	{
	}

	private void OnWinMVPChanged(List<object> obj)
	{
	}

	private void OnLoseMVPChanged(List<object> obj)
	{
	}

	private void OnScore5Changed(List<object> obj)
	{
	}

	private void OnScore4Changed(List<object> obj)
	{
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

	private void UpdateTitleList()
	{
	}

	private void UpdateMainScoreList()
	{
	}

	private void UpdatePlayerScore(int scoreIndex)
	{
	}

	private void UpdateMVPList(bool isWin)
	{
	}

	private void OnShowShareChanged(bool obj)
	{
	}

	private void OnShowReportChanged(bool obj)
	{
	}

	private void UpdateShowReport(bool flag)
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

	private void UpdateShowLike(bool flag)
	{
	}

	private void UpdateMatchStats(MatchStats stats)
	{
	}

	private void OnShowEcconomyChanged(bool obj)
	{
	}

	private void OnShowFriendChanged(bool obj)
	{
	}

	private void UpdateShowAddFriend(bool flag)
	{
	}

	private void OnShowGiftChanged(bool obj)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnShowMapEvaluateChanged(bool cur)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected override void OnClickNextBtn()
	{
	}

	protected override void AdjustCountDownLabelPos()
	{
	}

	public new void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsShowReplayBtn()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnClickNextBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_AdjustCountDownLabelPos()
	{
	}
}
