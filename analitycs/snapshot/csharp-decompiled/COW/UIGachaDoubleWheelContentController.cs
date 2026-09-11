using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaDoubleWheelContentController : UIGachaContentBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__38_0;

		public static EventDelegate.Callback _003C_003E9__39_0;

		public static Comparison<GachaShowItem> _003C_003E9__67_0;

		internal void _003CShowNewBieGuideFirstStep_003Eb__38_0()
		{
		}

		internal void _003CShowNewBieGuideSecondStep_003Eb__39_0()
		{
		}

		internal int _003CRefreshRewardPool_003Eb__67_0(GachaShowItem x, GachaShowItem y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public GachaDoubleWheelInfo dwInfo;

		internal bool _003CFlashingRoutine_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public GachaDoubleWheelInfo dwInfo;

		internal bool _003CFlashingRoutine2_003Eb__0(GachaShowItem x)
		{
			return false;
		}

		internal bool _003CFlashingRoutine2_003Eb__1(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public GachaResultInfo result;

		public int j;

		public Predicate<GachaShowItem> _003C_003E9__0;

		internal bool _003CFlashingRoutine3_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public GachaShowItem showItem;

		internal bool _003CClearAllCommonRewards_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003CCoShowRefundRuleTips_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoShowRefundRuleTips_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CFlashingRoutine2_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelContentController _003C_003E4__this;

		private _003C_003Ec__DisplayClass86_0 _003C_003E8__1;

		private List<float> _003CintervalList_003E5__2;

		private List<int> _003CrandomList_003E5__3;

		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFlashingRoutine2_003Ed__86(int _003C_003E1__state)
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

	private sealed class _003CFlashingRoutine3_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelContentController _003C_003E4__this;

		private _003C_003Ec__DisplayClass93_0 _003C_003E8__1;

		private GachaDoubleWheelInfo _003CdwInfo_003E5__2;

		private List<float> _003CintervalList_003E5__3;

		private bool _003Cfirst_003E5__4;

		private int _003Ci_003E5__5;

		private int _003Cindex_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFlashingRoutine3_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CFlashingRoutine4_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelContentController _003C_003E4__this;

		private int _003ClastIndex_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFlashingRoutine4_003Ed__91(int _003C_003E1__state)
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

	private sealed class _003CFlashingRoutine_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelContentController _003C_003E4__this;

		private _003C_003Ec__DisplayClass76_0 _003C_003E8__1;

		private int _003ClastIndex_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFlashingRoutine_003Ed__76(int _003C_003E1__state)
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

	private sealed class _003CPlayPrizeSelectedSound_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayPrizeSelectedSound_003Ed__89(int _003C_003E1__state)
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

	private sealed class _003CPlayUnlockAnim_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaDoubleWheelContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayUnlockAnim_003Ed__95(int _003C_003E1__state)
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

	private UIGachaDoubleWheelContentView m_View;

	private GachaInfo m_GachaInfo;

	private ClientChestType m_ClientChestType;

	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	private UIFrontEndPreviewWeaponPropertyPanelBaseController m_weaponPropertyCtrl;

	private List<GachaShowItem> m_GrandPrizeList;

	private List<GachaShowItem> m_CommonRewardList;

	private List<Transform> m_SingularGrandPrizeTransList;

	private List<Transform> m_PluralGrandPrizeTransList;

	private List<Transform> m_CommonRewardTransList;

	private List<UIGachaDoubleWheelGrandPrizeItemController> m_GrandPrizeItemList;

	private List<UIGachaDoubleWheelCommonRewardItemController> m_CommonRewardItemList;

	private float m_InitialInterval;

	private float m_InitialInterval2;

	private float m_FinalInterval;

	private float m_FinalInterval2;

	private float m_Duration;

	private float m_Duration2;

	private bool m_IsFlashing;

	private bool m_IsFlashing3;

	private bool m_IsFlashing4;

	private float m_CurrentInterval;

	private float m_ElapsedTime;

	private uint m_CarouselDelayCall;

	private uint m_CurrentShowModel;

	private int m_CarouselIndex;

	private Coroutine m_FlashingCoroutine;

	private UIFrontEndPreviewCollectionOnTrialController m_TrialBtnCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnUIInit()
	{
	}

	private void InitGrandPrizeTransList()
	{
	}

	private void InitCommonRewardTransList()
	{
	}

	public override void OnShowContent()
	{
	}

	private void ShowRefundRuleTips()
	{
	}

	private IEnumerator CoShowRefundRuleTips()
	{
		return null;
	}

	private void TryShowNewBieGuide()
	{
	}

	private void ShowNewBieGuideFirstStep()
	{
	}

	private void ShowNewBieGuideSecondStep()
	{
	}

	private void ShowNewBieGuideThirdStep()
	{
	}

	private void ShowCollectionTrailGuide()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	protected override void OnRefreshUIView()
	{
	}

	private void CheckShowPrimeAccess()
	{
	}

	public override Transform GetPrimeCountDownPos()
	{
		return null;
	}

	public override Transform GetNoPrimeTipsTrans()
	{
		return null;
	}

	private void RefreshPrimeShowState()
	{
	}

	private void ClearCache()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CarouselShowPreview()
	{
	}

	private void ContinueShowPreview()
	{
	}

	private void ShowPreview(bool needSkipAnim = false)
	{
	}

	private void RefreshTrialBtn(uint itemId = 0u)
	{
	}

	private void CancelCarousel()
	{
	}

	private void RefreshShowWeaponOrVehicle(uint modelID)
	{
	}

	private void InitWeaponScoreItem()
	{
	}

	private void ResetAnim()
	{
	}

	private void RefreshBG()
	{
	}

	private void SetKeyCDN()
	{
	}

	private void RefreshKey()
	{
	}

	private void RefreshLoopVFX()
	{
	}

	private void RefreshRuleTips()
	{
	}

	private void RefreshGuaranteedTips(bool needAnim = false)
	{
	}

	private void RefreshFinishedTips()
	{
	}

	private void RefreshRewardPool()
	{
	}

	private void RefreshGrandPrizes(List<GachaShowItem> dataList, List<UIGachaDoubleWheelGrandPrizeItemController> ctrlList, List<Transform> transList)
	{
	}

	private void RefreshCommonRewards(List<GachaShowItem> dataList, List<UIGachaDoubleWheelCommonRewardItemController> ctrlList, List<Transform> transList)
	{
	}

	public override void OnPurchaseResult(bool isSuccess, bool isRepurchase)
	{
	}

	private void ShowBuyBtn()
	{
	}

	private void HideBuyBtn()
	{
	}

	private void ShowDrawResult()
	{
	}

	public override void OnSkipAnim()
	{
	}

	private void StartFlashing()
	{
	}

	private IEnumerator FlashingRoutine()
	{
		return null;
	}

	private void UnHighlightAll()
	{
	}

	private void ResetKeyHighlight()
	{
	}

	private void HighlightKey1(bool keep = false)
	{
	}

	private void HighlightKey2(bool keep = false)
	{
	}

	private void SetFinished(int index)
	{
	}

	private bool IsAllCommonRewardFinished()
	{
		return false;
	}

	private void HighlightRemainRewards()
	{
	}

	private void HighlightItem(int index, bool final = false, bool keep = false)
	{
	}

	private void StartFlashing2()
	{
	}

	private IEnumerator FlashingRoutine2()
	{
		return null;
	}

	private void UnHighlightAll2()
	{
	}

	private void HighlightItem2(int index, bool final = false)
	{
	}

	private IEnumerator PlayPrizeSelectedSound()
	{
		return null;
	}

	private void StartFlashing4()
	{
	}

	private IEnumerator FlashingRoutine4()
	{
		return null;
	}

	private void StartFlashing3()
	{
	}

	private IEnumerator FlashingRoutine3()
	{
		return null;
	}

	private void PlayGrandPrizeDrawAnim()
	{
	}

	private IEnumerator PlayUnlockAnim()
	{
		return null;
	}

	private void ClearAllCommonRewards()
	{
	}

	protected override void OnCloseRewardPanel()
	{
	}

	private void RefreshCDN()
	{
	}

	private void RefreshProbabilityTipsLabel()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnKeyButtonClick()
	{
	}

	private void OnPriceNoticeBtnClick()
	{
	}

	private void OnPropertyBtnClick()
	{
	}

	private void OnRareProbabilityClick()
	{
	}

	private void OnPurchasePrepare(object[] param)
	{
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	private void _003CShowNewBieGuideThirdStep_003Eb__40_0()
	{
	}

	private void _003CCarouselShowPreview_003Eb__52_0()
	{
	}

	private void _003CRefreshBG_003Eb__60_0()
	{
	}

	private void _003CRefreshCDN_003Eb__98_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__100_0()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	public FrontendPreviewType _003C_003EiFixBaseProxy_GetFrontendPreviewType(uint P0)
	{
		return FrontendPreviewType.Lobby;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public Transform _003C_003EiFixBaseProxy_GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetNoPrimeTipsTrans()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseRewardPanel()
	{
	}
}
