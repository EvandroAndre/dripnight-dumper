using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UICSLadderMatchSeasonChangeController : UIPopupWindowController
{
	public class SeasonRewardEasyList : IEasyList
	{
		private UICSLadderMatchSeasonChangeController seasonchangeCtrl;

		public SeasonRewardEasyList(UICSLadderMatchSeasonChangeController seasonchangeController)
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
		private UICSLadderMatchSeasonChangeController seasonchangeCtrl;

		public ExchangeRewardEasyList(UICSLadderMatchSeasonChangeController seasonchangeController)
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

	private UIModelCSLadderMatch m_LadderModel;

	private SeasonRewardEasyList m_SeasonRewardEasyList;

	private ExchangeRewardEasyList m_ExchangeRewardEasyList;

	private UIFrontEndPreviewItemDescBaseController m_UIFrontEndPreviewItemDescBaseController;

	private int btn_click_count;

	private bool m_WaitForEnd;

	private const float NEEDWAITTIME = 0.5f;

	private float m_WaitForEndTime;

	private float m_ClickWaitTime;

	private bool m_CanClick;

	private CSRankingInfo lastSeasonInfo;

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

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void ShowNewSeasonInfo()
	{
	}

	private void ShowSeasonRank(uint rank, uint peakRankPos, string label_show, bool currentSeason)
	{
	}

	private void ShowBigAward()
	{
	}

	private void ShowRankSeasonTime(int seasonID)
	{
	}

	private void OnContinueBtnClick()
	{
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
