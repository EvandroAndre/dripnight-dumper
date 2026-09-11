using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UILadderMatchSeasonChangeController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public class SeasonRewardEasyList : IEasyList
	{
		private UILadderMatchSeasonChangeController seasonchangeCtrl;

		public SeasonRewardEasyList(UILadderMatchSeasonChangeController seasonchangeController)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	public class ExchangeRewardEasyList : IEasyList
	{
		private UILadderMatchSeasonChangeController seasonchangeCtrl;

		public ExchangeRewardEasyList(UILadderMatchSeasonChangeController seasonchangeController)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	private LadderMatchSeasonChangePopupView m_View;

	private UIModelLadderMatch m_LadderModel;

	private SeasonRewardEasyList m_SeasonRewardEasyList;

	private ExchangeRewardEasyList m_ExchangeRewardEasyList;

	private UIFrontEndPreviewItemDescBaseController m_UIFrontEndPreviewItemDescBaseController;

	private int btn_click_count;

	private bool m_WaitForEnd;

	private const float NEEDWAITTIME = 0.5f;

	private float m_WaitForEndTime;

	private float m_ClickWaitTime;

	private bool m_CanClick;

	private RankingInfo lastSeasonInfo;

	private uint m_DelayCallTid;

	private const float DELAYTIME = 0.25f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void ShowBigAward()
	{
	}

	private void ShowNewSeasonInfo()
	{
	}

	private void ShowRankSeasonTime(RankingSeasonInfo info)
	{
	}

	private void ShowSeasonRank(uint rank, uint peakRankPos, string label_show, bool currentSeason)
	{
	}

	private void OnContinueBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnContinueBtnClick_003Eb__26_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
