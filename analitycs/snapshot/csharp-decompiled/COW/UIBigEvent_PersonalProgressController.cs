using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgressController : UINavigationController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private sealed class _003CWaitNextTip_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_PersonalProgressController _003C_003E4__this;

		private string _003CassistantInfoKey_003E5__2;

		private uint _003CassistantTokenAmount_003E5__3;

		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitNextTip_003Ed__38(int _003C_003E1__state)
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

	private UIBigEvent_PersonalProgressView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_PersonalProgress m_UIModel;

	private List<UIBigEvent_PersonalProgress_BtnItemController> m_LeftBtnControllers;

	private List<UIBigEvent_PersonalProgress_BarItemController> m_PersonalBarRewardItemControllers;

	private UIStandardAdsController m_AdsCtrl;

	private UIBigEvent_PersonalProgressHelpTipController m_HelpTipCtrl;

	private UIBigEvent_PersonalProgress_TokenItemController m_TokenCtrl;

	private const int m_AdsDotWidth = 33;

	private const int m_AdsDotHeight = 5;

	private const int m_AdsGridCellWidth = 38;

	private const int m_AdsContentColliderWidth = 400;

	private const int m_AdsContentColliderHeight = 570;

	private const int m_ContentWidth = 400;

	private const int m_ContentHeight = 520;

	private const int m_AdsTextureWidth = 392;

	private const int m_AdsTextureHeight = 512;

	private const int m_AdsContentColliderY = -25;

	private const int m_DotBelowCDNPosY = -325;

	private float m_WaitNextTipTime;

	private float m_TopLeftOffsetY;

	private Coroutine m_WaitNextTipCoroutine;

	private bool m_hasInitTemplateUI;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshView()
	{
	}

	private void RefreshProgressBar()
	{
	}

	private void RefreshGridLeftBtns()
	{
	}

	private void RefreshShareBtnBubble()
	{
	}

	private void RefreshTokenView()
	{
	}

	private void ShowHelpTipsByAssistanceInfos()
	{
	}

	private IEnumerator WaitNextTip()
	{
		return null;
	}

	private void OnClickBtnRule()
	{
	}

	private void OnClickBtnClose()
	{
	}

	private void OnClickStandardAds(object[] data)
	{
	}

	private void OnClickBtnShare()
	{
	}

	private void SetShareBgView(bool show)
	{
	}

	private void OnGotoNavigation(uint entranceType)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
