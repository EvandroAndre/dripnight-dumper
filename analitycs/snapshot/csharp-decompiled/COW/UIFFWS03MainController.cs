using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIFFWS03MainController : UIBigEventMainBaseController
{
	private sealed class _003CEnterAnimCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFFWS03MainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEnterAnimCoroutine_003Ed__22(int _003C_003E1__state)
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

	private UIFFWS03MainView m_View;

	private UIModelFFWS03 m_ModelFFWS03;

	private UIBigEventTopBtnBaseController m_TopBtnCtrl;

	private const string m_GuessGuideKey = "FFWS03GuideKey_";

	private const string m_TeamShowKey = "FFWS03TeamShowKey_";

	private const string m_AutoShowChampionKey = "FFWS03AutoShowChampionKey_";

	private const string m_AutoShowWarmUpKey = "FFWS03AutoShowWarmUpKey_";

	private bool m_AutoShowChampion;

	private UICommonGuideController m_GuessGuideCtrl;

	private UIFFWS03WarmUpController m_WarmUpCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override string GetEntranceOverStateTipKey()
	{
		return null;
	}

	public override UIBigEventPeakDayWndBaseController GetPeakDayWndCtrl()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnWarmUpClose()
	{
	}

	private IEnumerator EnterAnimCoroutine()
	{
		return null;
	}

	private void OnBtnRuleClick()
	{
	}

	private void OnPlayNormalClickSound()
	{
	}

	private void OnBtnManagerClick()
	{
	}

	private void OnBtnGuessClick()
	{
	}

	public void RefreshBtnTipState()
	{
	}

	private void OnBtnCupClick()
	{
	}

	public override void RefreshView()
	{
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public string _003C_003EiFixBaseProxy_GetEntranceOverStateTipKey()
	{
		return null;
	}

	public UIBigEventPeakDayWndBaseController _003C_003EiFixBaseProxy_GetPeakDayWndCtrl()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
