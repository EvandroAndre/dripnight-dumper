using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanMainPageController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
{
	private sealed class _003CDelayInit_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanMainPageController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayInit_003Ed__34(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIClanMainPageView m_View;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClanTrend m_ModelClanTrend;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private UILobbyChatController m_ChatBtn;

	private ClanLuckyBagConfigData m_ClanLuckyBagConfigData;

	private List<UIClanContributionItemController> m_ClanContributionItems;

	private List<UIClanActivenessProgressBarItemController> m_ClanActivenessProgressBarItems;

	private UIClanWarV2LeaderBoardMiniController m_UIClanWarV2LeaderBoardMiniController;

	private UILeaderBoardTitleSingleController m_ClanWarTitle;

	private UITipsNormalController m_SettingTipsCtrl;

	private const uint RecentlyItemNum = 3u;

	private bool m_IsCurrentTab;

	private GameObject m_VFX;

	private bool m_HasDelayInit;

	private const int PROGRESS_BAR_GUIDE_DEPTH = 19;

	private const int CLAN_MALL_GUIDE_DEPTH = 19;

	private const string CLAN_MAIN_PAGE_SETTING_KEY = "CLAN_MAIN_PAGE_SETTING_KEY_{0}";

	private uint m_ClanPrivilegeVFXDelayCall;

	private uint m_ClanPrivilegeFirstVFXDelayCall;

	private Vector3 m_NoLowActivityPosition;

	private Vector3 m_HasLowActivityPosition;

	private bool m_IsClanHacker;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void ShowProgressBarGuide()
	{
	}

	public void ShowClanMallGuide()
	{
	}

	private void OnTabSelected(object[] param)
	{
	}

	private IEnumerator DelayInit()
	{
		return null;
	}

	private void RefreshMainPage()
	{
	}

	private void RefreshClanInfo()
	{
	}

	private void RefreshPrivilegeRedDot()
	{
	}

	private void RefreshClanSettingRedDot()
	{
	}

	private void RefreshClanTotalActivenessLabel()
	{
	}

	private void ShowProgressBar(UIProgressBar progressBar, int MaxValue, int MinValue, bool isDegardeBar = false)
	{
	}

	private void RefreshClanActive()
	{
	}

	private void RefreshRightInfo()
	{
	}

	private void InitActiveProcess()
	{
	}

	private void RefreshClanProgressBar()
	{
	}

	private void RefreshClanWarInfo()
	{
	}

	private void RefreshClanWarEmblem()
	{
	}

	private string GetLevelDetailString(ClanLevelData data)
	{
		return null;
	}

	private void OnBtnApplyClick()
	{
	}

	private void OnSettingClicked()
	{
	}

	private void OnBuffClicked()
	{
	}

	private void OnOpenRankList()
	{
	}

	private void OnClickClanWarLeaderboardBtn()
	{
	}

	private void OnInviteClick()
	{
	}

	private void OnClanShopBtnClick()
	{
	}

	private void OnInviteFriendBtnClick()
	{
	}

	private void OnClickObtainBtn()
	{
	}

	private void OnClickWeeklyTeamworkRewardRuleBtn()
	{
	}

	private void OnClickClanIdCopyBtn()
	{
	}

	private void OnClickRegionBtn()
	{
	}

	private void OnClanNoticeBtnClick()
	{
	}

	private void OnClanHackerRemindRuleBtnClick()
	{
	}

	private void SelectRegion(object[] data)
	{
	}

	private void RefreshLowActivityRemind()
	{
	}

	private void RefreshClanHackerRemind()
	{
	}

	private void CheckIsClanHacker()
	{
	}

	private void RefreshRightRemindContainer()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void TryInitTips()
	{
	}

	public void OpenClanRequestWnd()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void RefreshClanPrivilegeInfo()
	{
	}

	private void TryShowClanPrivilegeVFX()
	{
	}

	private void OnPrivilegeClaimBtnClick()
	{
	}

	private void AutoOpenClanLocationSetting()
	{
	}

	private void _003CTryShowClanPrivilegeVFX_003Eb__73_0()
	{
	}

	private void _003CTryShowClanPrivilegeVFX_003Eb__73_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
