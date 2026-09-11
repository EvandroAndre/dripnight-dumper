using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBooyahPasMainController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public BPEventExpression desc;

		internal void _003CPrepareTopBarTokens_003Eb__0()
		{
		}

		internal void _003CPrepareTopBarTokens_003Eb__1()
		{
		}
	}

	private sealed class _003CShowInitEffect_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPasMainController _003C_003E4__this;

		private bool _003CneedReset_003E5__2;

		private UIBooyahPassPurchaseRewardTipsWndController _003CrewardTipsCtrl_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowInitEffect_003Ed__102(int _003C_003E1__state)
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

	private sealed class _003CShowPrivilegeActivateWnd_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPasMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowPrivilegeActivateWnd_003Ed__106(int _003C_003E1__state)
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

	private sealed class _003CShowPrivilegeGainWnd_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPasMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowPrivilegeGainWnd_003Ed__105(int _003C_003E1__state)
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

	private sealed class _003CShowStateChangeEffect_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPasMainController _003C_003E4__this;

		public bool canShowGradeBrushLightEffetct;

		public bool showPrivilegeWnd;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowStateChangeEffect_003Ed__103(int _003C_003E1__state)
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

	private sealed class _003CStatusLevelExpChangeProcedure_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPasMainController _003C_003E4__this;

		private bool _003CisScrollViewLevelUpEffectAvailable_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStatusLevelExpChangeProcedure_003Ed__104(int _003C_003E1__state)
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

	private const string NORMAL_GEM_SPRITE_NAME = "FF_UI_FlashStore_Diamond";

	private const string GUIDE_STEP1_KEY = "BooyahPassMain_Step1_Account{0}";

	private const string GUIDE_STEP2_KEY = "BooyahPassMain_Step2_Account{0}";

	private const string GUIDE_STEP3_KEY = "BooyahPassMain_Step3_Account{0}";

	private const string BOOYAHPASS_MAIN_LOG = "BooyahPassMain";

	private UIBooyahPassMainView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIBooyahPassUnlockedSharePopupWndController m_UnlockShareCtrl;

	private UIBooyahPassPrivilegeWndController m_PrivilegeWndCtrl;

	private GuideQueue m_GuideQueue;

	private UINewDownloadInfoController m_DownloadCtrl;

	private Vector2 SINGLEPPREWARD_SIZE;

	private Vector2 DOUBLEPPREWARD_SIZE;

	private Vector2 SEPARATOR_SIZE;

	private Vector2 THREEPPREWARD_SIZE;

	private Vector2 FOURPPREWARD_SIZE;

	private Vector2 FIVEPPREWARD_SIZE;

	private readonly Vector2 fpEpIconPos;

	private readonly Vector2 bpEpIconPos;

	private readonly Vector3 PrivilegeBtnTaskPos;

	private readonly Vector3 missionWithoutRedPos;

	private readonly Vector3 missionWithRedPos;

	private readonly Vector3 m_GotoTokenOffset;

	private readonly float m_BigRewardOffset;

	private UITable2.Item m_DefaultRewardItem;

	private UITable2.Item m_FPSeparator;

	private int m_LastIndexClicked;

	private uint m_LastClickedRewardGrade;

	private bool m_ScrollAgain;

	private bool m_HasInitData;

	private bool m_IsFP;

	private bool m_HasDoneGuide;

	private uint m_CurPlayerGrade;

	private uint m_ScrollBgValue;

	private bool m_ShowLevelUpEffect;

	private bool m_hasDownloadVideo;

	private bool m_IsBooyahPassShareExpDataProcessed;

	private bool m_HasInitTopBarView;

	private int m_BpDiscountSpriteWidth;

	private int m_SaleBgWidth;

	private uint m_DelayCall;

	private bool m_IsRoyalReadyExipred;

	private NewBieGuildBasProcessor m_CurBasProcessor;

	private GameObject m_UIFX_ExperieBar;

	private GameObject m_UIFX_UNLock;

	private GameObject m_UIFX_UPUnlock;

	private GameObject m_UIFX_LVUP;

	private GameObject m_UIFX_LV_UP;

	private bool m_IsInitEffectPlaying;

	private int m_CurBigRewardIndex;

	private int m_CurBigBaseIndex;

	private BooyahPassBaseItemData m_CurBigBaseItem;

	private float m_CurRightLinePosX;

	private uint m_ScrollToGrade;

	private uint m_ScrollToItemId;

	private ulong m_AccountID;

	private IEnumerator m_StartShowAllEffect;

	private IEnumerator m_SratShowStateEffect;

	private Coroutine m_StatusLevelExpChangeCoroutine;

	private Vector3 PrivilegeBtnPurchasePos;

	private bool m_IsForbid;

	public int LastIndexClicked => 0;

	public bool IsBooyahPassShareExpDataProcessed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ChangeForbidEscState(bool isForbid)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void ShowNewbieGuide()
	{
	}

	private void ShowRewardLineGuide()
	{
	}

	private void ShowGradeLine()
	{
	}

	private void ShowMissionGuide()
	{
	}

	private void RefreshPrivilegeTable()
	{
	}

	private void RequestNecessaryMessage()
	{
	}

	private void InitData()
	{
	}

	private void LevelUp()
	{
	}

	private void RefreshRightView()
	{
	}

	private void RefreshView()
	{
	}

	private void OpenChildWindowByType(UINavigationUtil.UINavigationBooyahPassType type)
	{
	}

	private void RefreshSendPremiumPassEntrance()
	{
	}

	private void RoyalOnFinish()
	{
	}

	private void RefreshTopBtn()
	{
	}

	private void ShowPurchaseTipsWnd()
	{
	}

	private void HideBackFlow()
	{
	}

	private void RefreshSocialExperienceBtnView(object[] data)
	{
	}

	private void RefreshBottomBtnView()
	{
	}

	private void RefreshBigReward(bool force)
	{
	}

	private void RefreshRewardItemList()
	{
	}

	private void InitRewardItemList()
	{
	}

	private void StartShowInitEffect(object[] data)
	{
	}

	private IEnumerator ShowInitEffect()
	{
		return null;
	}

	private IEnumerator ShowStateChangeEffect(bool canShowGradeBrushLightEffetct = true, bool showPrivilegeWnd = false)
	{
		return null;
	}

	private IEnumerator StatusLevelExpChangeProcedure()
	{
		return null;
	}

	private IEnumerator ShowPrivilegeGainWnd()
	{
		return null;
	}

	private IEnumerator ShowPrivilegeActivateWnd()
	{
		return null;
	}

	private void StartStatusLevelExpChangeProcedure()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void StartShowChangeEffect()
	{
	}

	private void ShowItemUnlockEffect()
	{
	}

	private void SetCDNTexture()
	{
	}

	private void OnDowloadFinishedSingleType(ResultTextureInfo textureInfo)
	{
	}

	private void OnDowloadFinishedDoubleType(ResultTextureInfo textureInfo)
	{
	}

	private void OnDowloadFinishedMiddleType(ResultTextureInfo textureInfo)
	{
	}

	private void OnDowloadFinishedThreeRewardType(ResultTextureInfo texture)
	{
	}

	private void OnDowloadFinishedFourRewardType(ResultTextureInfo texture)
	{
	}

	private void OnDowloadFinishedFiveRewardType(ResultTextureInfo texture)
	{
	}

	private void OnDownLoadFinishiedCycleType(ResultTextureInfo texture)
	{
	}

	private void PrepareTopBarTokens()
	{
	}

	private static void OnTopBarGemsTokenClick()
	{
	}

	private void Update()
	{
	}

	private void OnBigRewardBtnClick()
	{
	}

	private void ClaimCurBigRewardItem()
	{
	}

	private void OnShowNextBigRewardBtnClick()
	{
	}

	private void ScrollToSpecifiedPos(bool backToDefaultPos, bool scrollToHead = true, bool force = false)
	{
	}

	private void InitBPRewardItemTemplate()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnRoyalBtnClick()
	{
	}

	private void OnLimitedBtnClick()
	{
	}

	private void OnArrowBtnClick()
	{
	}

	private void OnPremiumPassSentSuccess()
	{
	}

	private void OnPrizeBtnClick()
	{
	}

	private void OnShowPrivilegeBtnClick(EPrivilegeIndex index)
	{
	}

	private void OnBackFlowPrivilegeBtnClick()
	{
	}

	private void OnUnlockBtnClick()
	{
	}

	private void OnSocialExperienceBtnClick()
	{
	}

	private void OnMissionBtnClick()
	{
	}

	private void OpenDuoShareCtrl()
	{
	}

	private void OnSendPPBtnClick()
	{
	}

	private void OnExpreienceTipBtnClick()
	{
	}

	private void OnGainExperienceBtnClick()
	{
	}

	private void OnPrivilegeBtnClick()
	{
	}

	private void OnClaimAllBtnClick()
	{
	}

	private void OnPreviewItem(object[] param)
	{
	}

	private void ShowUnlockedSharePopupWnd()
	{
	}

	private void ShowReceivePremiumPassPopupWndIfReceived()
	{
	}

	private void _003COnUIInit_003Eb__71_0()
	{
	}

	private void _003COnUIInit_003Eb__71_1()
	{
	}

	private void _003COnUIInit_003Eb__71_2()
	{
	}

	private void _003COnUIInit_003Eb__71_3()
	{
	}

	private void _003CShowRewardLineGuide_003Eb__81_0()
	{
	}

	private void _003CShowGradeLine_003Eb__82_0()
	{
	}

	private void _003CShowMissionGuide_003Eb__83_0()
	{
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_4()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_5()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_6()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_7()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_8()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__126_9()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
