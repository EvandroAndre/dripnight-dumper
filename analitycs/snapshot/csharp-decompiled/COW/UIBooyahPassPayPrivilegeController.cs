using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIBooyahPassPayPrivilegeController : UINavigationController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public UIBooyahPassPayPrivilegeController _003C_003E4__this;

		public Vector3 itemScale;

		internal UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__0()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UIBooyahPassUnlockedSharePopupWndController popup;

		public UIBooyahPassPrivilegeWndController ctrl;

		internal bool _003CBooyahPassPurchasedCoroutine_003Eb__0()
		{
			return false;
		}

		internal bool _003CBooyahPassPurchasedCoroutine_003Eb__1()
		{
			return false;
		}
	}

	private sealed class _003CBooyahPassPurchasedCoroutine_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassPayPrivilegeController _003C_003E4__this;

		public bool isPremiumPlus;

		private _003C_003Ec__DisplayClass54_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CBooyahPassPurchasedCoroutine_003Ed__54(int _003C_003E1__state)
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

	private sealed class _003CShowActiveEffect_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassPayPrivilegeController _003C_003E4__this;

		public Vector3 posFrom;

		private bool _003CshowTrailVFX_003E5__2;

		private GameObject _003CPremiunTrailVFX_003E5__3;

		private GameObject _003CPremiunTrailPlusVFX_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowActiveEffect_003Ed__37(int _003C_003E1__state)
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

	private UIBooyahPassPayPrivilegeView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private UICommonDiamondPurchaseBtnController m_PremiumPass1PurchaseBtn;

	private UICommonDiamondPurchaseBtnController m_PremiumPass2PurchaseBtn;

	private Coroutine m_BooyahPassPurchasedCoroutine;

	private Vector2 MINIREWARD_SIZE;

	private Vector2 MAXREWARD_SIZE;

	private const int SCROLL_COUNT = 40;

	private const uint BIG_REWARD_NUM = 2u;

	private const string NAVIGATION_TITLE = "PayPrivilegeNavigation";

	private const string NORMAL_GEM_SPRITE_NAME = "FF_UI_FlashStore_Diamond";

	private const string BOOYAHPASS_PAY_LOG = "BooyahPassPayPrivilege";

	private List<UIBooyahPassImportantRewardMaxController> m_BigRewardList;

	private IEnumerator m_ShowActiveEffect;

	private bool m_HasInitTopBarView;

	private UIBooyahPassPrivilegeWndController m_PrivilegeCtrl;

	private bool m_IsForbid;

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

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void RefreshView()
	{
	}

	private void ChangeForbidEscState(bool isForbid)
	{
	}

	private void ShowNewBieGuide()
	{
	}

	private void ShowBeginGuide()
	{
	}

	private void ShowRewardGuide()
	{
	}

	private void ShowPayGuide()
	{
	}

	private void SetCndTexture()
	{
	}

	private void InitTopBar()
	{
	}

	private static void OnTopBarGemsTokenClick()
	{
	}

	private void RefreshPrivilegeArea()
	{
	}

	private void RefreshRewardArea()
	{
	}

	private void RefreshPurchaseArea()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void ShowActivePrivilegeEffect(object[] param)
	{
	}

	private IEnumerator ShowActiveEffect(Vector3 posFrom)
	{
		return null;
	}

	private void ShowInitEffect()
	{
	}

	private void RefreshPurchaseButtonGroup(object[] data)
	{
	}

	private void RefreshPremiumDiamondPurchaseButton()
	{
	}

	private void RefreshPremiumPlusDiamondPurchaseButton()
	{
	}

	private void RefreshBackFlowView()
	{
	}

	private void PP1ShowPrivilegeWnd()
	{
	}

	private void PP2ShowPrivilegeWnd()
	{
	}

	private bool HasRepurchaseDiscount()
	{
		return false;
	}

	private void OnPremiumPass1PurchaseBtnClick()
	{
	}

	private void OnPremiumPass2PurchaseBtnClick()
	{
	}

	private void OpenSecondPurchaseConfirmWnd(BooyahPassStatusType type)
	{
	}

	private void BtnShowPirvilegeIntroduceWnd(EPrivilegeIndex index)
	{
	}

	private void InitBPRewardItemTemplate()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	private void StartBooyahPassPurchasedProcedure(bool success, bool isPremiumPlus)
	{
	}

	private IEnumerator BooyahPassPurchasedCoroutine(bool isPremiumPlus)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CShowBeginGuide_003Eb__26_0()
	{
	}

	private void _003CShowRewardGuide_003Eb__27_0()
	{
	}

	private void _003CShowPayGuide_003Eb__28_0()
	{
	}

	private void _003CRefreshPrivilegeArea_003Eb__32_3()
	{
	}

	private void _003CRefreshPrivilegeArea_003Eb__32_4()
	{
	}

	private void _003CRefreshPrivilegeArea_003Eb__32_0()
	{
	}

	private void _003CRefreshPrivilegeArea_003Eb__32_1()
	{
	}

	private void _003CRefreshPrivilegeArea_003Eb__32_2()
	{
	}

	private bool _003CShowActiveEffect_003Eb__37_0()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
