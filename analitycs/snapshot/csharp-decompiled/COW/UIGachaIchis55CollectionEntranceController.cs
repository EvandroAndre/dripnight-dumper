using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchis55CollectionEntranceController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UIGachaIchis55CollectionEntranceController _003C_003E4__this;

		public Action onFinished;

		internal void _003CPlayCollectItemFly_003Eb__0()
		{
		}
	}

	private sealed class _003CAutoHideBanner_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIGachaIchis55CollectionEntranceController _003C_003E4__this;

		public GameObject banner;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoHideBanner_003Ed__42(int _003C_003E1__state)
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

	private const float INIT_BANNER_DURATION = 10f;

	private const float PROGRESS_BANNER_DURATION = 5f;

	private const string PREFS_KEY_FMT_LAST_SEEN_COUNT = "Ichis55_CollEntrance_LastSeenCnt_{0}_{1}_{2}";

	private static readonly ResourceID FLY_TRAIL_FX;

	private const float FLY_SPEED = 2.5f;

	private UIGachaIchis55CollectionEntranceView m_View;

	private UIModelIchis m_ModelIchis;

	private UIModelInventory m_ModelInventory;

	private string m_PrefsKeyLastSeenCount;

	private UITipsNormalController m_TipCtrl;

	private Coroutine m_BannerCoroutine;

	private int m_LastSeenCount;

	private int m_CollectedCount;

	private int m_TotalCount;

	private bool m_IsClaimable;

	private bool m_HasUnseenItems;

	private bool m_HasNewRewardCollectionItems;

	private bool m_HasShownInitBanner;

	private bool m_RewardClaimed;

	private uint m_ChestId;

	private uint m_ChestSubId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetUIData(uint chestId, uint chestSubId)
	{
	}

	private void RefreshState()
	{
	}

	private void RefreshCollectState()
	{
	}

	private void OnCollectRewardClaimed()
	{
	}

	private void RefreshEntranceDisplay(bool allowInitBanner)
	{
	}

	private void RefreshIconTweenRotation()
	{
	}

	private void RefreshTips()
	{
	}

	private void ShowInitBanner()
	{
	}

	public void OnRewardWndClosed(bool hasNewCollectionItemAward, int collectedCountAfterDraw, Vector3 flyFromPos)
	{
	}

	private void ApplyCollectRewardProgress(bool hasNewCollectionItemAward, int collectedCountAfterDraw)
	{
	}

	private void ShowRewardCloseEffect(Vector3 flyFromPos)
	{
	}

	private void ShowCollectRewardBanner()
	{
	}

	private void ShowProgressBanner()
	{
	}

	private void ShowClaimableBanner()
	{
	}

	private void PlayCollectItemFly(Vector3 fromPos, Action onFinished)
	{
	}

	private void PlayMainVFX()
	{
	}

	private void ShowBanner(GameObject banner, UILabel bannerLabel, string text, float duration)
	{
	}

	private IEnumerator AutoHideBanner(GameObject banner, float delay)
	{
		return null;
	}

	private void HideAllBanners()
	{
	}

	private void StopBannerCoroutine()
	{
	}

	private void OnEntranceClick()
	{
	}

	public void MarkCollectionSeen()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
