using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISceneEditUserCenterController : UIBaseController, IUIModelDataChangeObserver
{
	public enum TabEnum
	{
		Subscription,
		History,
		Setting
	}

	private sealed class _003CPostUIOpen_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISceneEditUserCenterController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPostUIOpen_003Ed__19(int _003C_003E1__state)
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

	private UISceneEditUserCenterView m_View;

	private UIStandardDrawerTabRemakeController m_TabCtrl;

	public Action ClickSubscriptionAction;

	public Action onClickTabAction;

	private UISceneEditHistoryInfoController m_HistoryInfoCtrl;

	private UISceneEditSubscriptionInfoController m_SubscriptionInfoCtrl;

	private UISceneEditSettingInfoController m_SettingInfoCtrl;

	private UIModelSceneEdit m_Model;

	private bool m_IsFeedBackInCD;

	private int m_CurTabIndex;

	private int m_TargetTabIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SelectMainTabByIndex(int index)
	{
	}

	public int GetCurTabIndex()
	{
		return 0;
	}

	public int GetHistoryCurTabIndex()
	{
		return 0;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private IEnumerator PostUIOpen()
	{
		return null;
	}

	private void OnMainTabClick(TabEnum tab)
	{
	}

	private void InitStandardTabs()
	{
	}

	public bool HasRedPoint()
	{
		return false;
	}

	private void OnProfileProgressClick()
	{
	}

	private void OnFeedBackBtnClick()
	{
	}

	public void RefreshFeedBackBtn()
	{
	}

	private void OnUpdatePersonServer()
	{
	}

	private void CheckLevelRankReward()
	{
	}

	private void OnCloseRankRewardLevelUpView(object[] data)
	{
	}

	private void OnRankRewardLevelUp(object[] data)
	{
	}

	private void OnUpdatePersonInfo(object[] data)
	{
	}

	private void OnDetailClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void StoreBeforeClose()
	{
	}

	public void RestoreWhenOpen()
	{
	}

	private void _003CInitStandardTabs_003Eb__21_0()
	{
	}

	private void _003CInitStandardTabs_003Eb__21_1()
	{
	}

	private void _003CInitStandardTabs_003Eb__21_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
