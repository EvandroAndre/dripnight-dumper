using GCommon;
using proto;

namespace COW;

internal class UIHudBRMatchResultController : UIHudNormalMatchResultController
{
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public PlayerData player1;

		public PlayerData player2;

		internal bool _003CSortPlayerData_003Eb__0(TeammateStats x)
		{
			return false;
		}

		internal bool _003CSortPlayerData_003Eb__1(TeammateStats x)
		{
			return false;
		}
	}

	private UIMatchResultWinStreakController m_WinStreakCtrl;

	private UIMatchResultWinStreakSpecialController m_WinStreakSpecialCtrl;

	private UITipsNormalController m_NewDataPageTipsCtrl;

	private UICommonGuideController m_MatchReviewGuideCtrl;

	private bool m_IsMatchReviewBubbleVisible;

	private UIModelBRMatchReview m_ModelBRMatchReview;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAIChatTryShow()
	{
	}

	private bool ShouldShowMatchReviewButton()
	{
		return false;
	}

	private ulong GetMatchIdForReview()
	{
		return 0uL;
	}

	private bool IsBRTutorialTaskMatchForReview()
	{
		return false;
	}

	private void RefreshMatchReviewButton(bool canShowGuide)
	{
	}

	private void RefreshMatchReviewBubble(bool shouldShowButton, bool canShowGuide)
	{
	}

	private bool CanTriggerMatchReviewBubble()
	{
		return false;
	}

	private uint GetMatchReviewGuideDuration()
	{
		return 0u;
	}

	private bool HasHigherPriorityGuide()
	{
		return false;
	}

	private bool ShouldShowBRRankRatingGuide()
	{
		return false;
	}

	private bool ShouldShowMatchReviewGuide()
	{
		return false;
	}

	private bool HasHigherPriorityHighlightTips()
	{
		return false;
	}

	private void ShowMatchReviewGuide()
	{
	}

	private void CloseMatchReviewGuide()
	{
	}

	private void OnClickMatchReview()
	{
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	private bool IsShowWinStreakUI()
	{
		return false;
	}

	protected override void OnShareBtnClick()
	{
	}

	protected override bool IsShowReportAndBlockBtn()
	{
		return false;
	}

	protected override void UpdateInfoTitles()
	{
	}

	private void SetBRDataTitlePos()
	{
	}

	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	private void OnClickTitleInfo2Tip()
	{
	}

	protected override void OnClickDataPageBtn()
	{
	}

	private void RefreshDataPageRedPoint()
	{
	}

	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	private void _003CShowMatchReviewGuide_003Eb__20_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnShareBtnClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsShowReportAndBlockBtn()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}

	public int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnClickDataPageBtn()
	{
	}

	public new int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}
