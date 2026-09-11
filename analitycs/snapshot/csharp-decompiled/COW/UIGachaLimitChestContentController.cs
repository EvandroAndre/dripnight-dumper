using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaLimitChestContentController : UIGachaContentBase, ILuckySpinContent
{
	public enum eUIGachaLimitChestState
	{
		eUIGachaLimitChestState_None,
		eUIGachaLimitChestState_SelectAni,
		eUIGachaLimitChestState_SelectPage1,
		eUIGachaLimitChestState_SelectPage2,
		eUIGachaLimitChestState_ShowItemComeOut,
		eUIGachaLimitChestState_ShowPrize,
		eUIGachaLimitChestState_ShowGachaLoading,
		eUIGachaLimitChestState_ShowEffectIdle,
		eUIGachaLimitChestState_ShowGachaLoadingEndEffect
	}

	public enum eUIGachaLimitChestPageNum
	{
		eUIGachaLimitChestPageNum_1,
		eUIGachaLimitChestPageNum_2
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIGachaLimitChestContentController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CInitShowOptionalDownloadInfo_003Eb__0()
		{
		}
	}

	private sealed class _003COnRewardPopUpCloseNextFrame_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaLimitChestContentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnRewardPopUpCloseNextFrame_003Ed__69(int _003C_003E1__state)
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

	private static eUIGachaLimitChestState m_curState;

	private UIGachaLimitChestContentView m_View;

	private bool m_bIsFilledItemRenderer;

	private UIGachaLimitChestSelectRewardItemController[] m_SelectableItemRenderers;

	private UIGachaLimitChestItemController[] m_itemRenderers;

	private int m_nFirstSelectIndex;

	private uint m_uFirstSelectID;

	private int m_nSecondSelectIndex;

	private uint m_uSecondSelectID;

	private uint m_LastGachaId;

	private float m_fLoadingEndEffectTimer;

	private float m_fLoadingEndEffectAllTimer;

	private GameObject m_PageStartEffect;

	private GameObject m_BoxEffectGo;

	private Animator m_BoxEffectAnimator;

	private float m_fShowSelectEffectTimer;

	private float m_fShowSelectEffectAllTimer;

	private float m_fShowIdleTimer;

	private float m_fAniCloseItemDescTimer;

	private string m_strDescKey;

	private bool m_bIsShowedSecondSelectPage;

	private GameObject m_audioSelectAni;

	private GameObject m_audioShowAni;

	private bool m_bIsSplashLock;

	private string m_strRules1PriceKey;

	private string m_strRules2PriceKey;

	private string m_strRules3PriceKey;

	private float m_fShowItemComeOutTimer;

	private float m_fShowItemComeOutAllTimer;

	private uint m_unGachaLoadingTarID;

	private int m_nGachaLoadingTarIndex;

	private int m_nGachaLoadingResIndex;

	private List<int> m_gachaLoadingIndexs;

	private float m_fGachaLoadingAllTimer;

	private float m_fGachaLoadingTimer;

	private float m_fGachaLoadingStartVelocity;

	private float m_fGachaLoadAddVelocity;

	private int m_nGachaLimitLoadingStartIndex;

	private int m_nLastIndex;

	public float[] testTimer;

	public float[] testStartVelocity;

	public static eUIGachaLimitChestState CurState => eUIGachaLimitChestState.eUIGachaLimitChestState_None;

	protected override void OnUIClose()
	{
	}

	public void ClearRecordLastGachaID()
	{
	}

	public override void OnShowContent()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	public override void OnHideContent()
	{
	}

	private void FillItemRenderer()
	{
	}

	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return FrontendPreviewType.Lobby;
	}

	private void OnRewardToggleChanged()
	{
	}

	private void PlayerLightningEffect()
	{
	}

	private void OnClickNextBtn()
	{
	}

	private void OnClickSelectConfirmBtn()
	{
	}

	private void OnClickSelectReward(int index)
	{
	}

	private Transform GetSelectNodeByIndex(int index)
	{
		return null;
	}

	private Transform GetItemRendererNodeByIndex(int index)
	{
		return null;
	}

	public void SetItemPreview(BaseItemInfo info, bool needSkipAnim = false)
	{
	}

	protected override void InitGachaContentBuyBtn()
	{
	}

	private void RefreshShowItemPage(bool isShowItemPreview = true, bool isClickShowItem = true, bool needSkipAnim = false)
	{
	}

	private void CloseItemRendererLightningEffect()
	{
	}

	protected override void OnRefreshUIView()
	{
	}

	private void StateUpdate()
	{
	}

	private void SwitchState(eUIGachaLimitChestState state, bool isClickShowItem = true, bool needSkipAnim = false)
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

	private void RefreshBuyNodeShowState(bool show)
	{
	}

	private void Update()
	{
	}

	private void SetProbabilityAcitive(bool b)
	{
	}

	private void SetPageStartEffectState(bool show)
	{
	}

	private void SetBoxEffectState(bool show)
	{
	}

	private Animator GetBoxEffectAnimator(bool ensureCreate = true)
	{
		return null;
	}

	private void OnClickShowItemRenderer(int index, bool needSkipAnim = false)
	{
	}

	private void RefreshTitleCDN()
	{
	}

	private void RefreshShowItemRenderer()
	{
	}

	private void RefreshSelectRewardPage(eUIGachaLimitChestPageNum num, bool isClickItem = true)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnSplashCDNOpen()
	{
	}

	public override void OnSplashCDNClose()
	{
	}

	public override void OnFullScreenAnimOver()
	{
	}

	public override void OnSkipFullScreenAnim()
	{
	}

	private IEnumerator OnRewardPopUpCloseNextFrame()
	{
		return null;
	}

	private void OnRewardPopWndClose(object[] data)
	{
	}

	private void OnRareProbabilityClick()
	{
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	private void OnClickToggle2(UIToggleButton button)
	{
	}

	private void OnClickToggle1(UIToggleButton button)
	{
	}

	private void RefreshPreviewScene()
	{
	}

	public override void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	private void StartShowItemLoadingEffectAni()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	private void SetShowRewardSelectIndex(int index)
	{
	}

	private void ExitGachaLoadingState()
	{
	}

	private void EnterGachaLoadingState()
	{
	}

	private void UpdateGachaLoadingState()
	{
	}

	private void RefreshShowItemStat()
	{
	}

	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	public override void OnSkipAnim()
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void RefreshLuckySpinBtn()
	{
	}

	public void OpenRewardWnd()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__22_0()
	{
	}

	private void _003CRefreshTitleCDN_003Eb__60_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHideContent()
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

	public Transform _003C_003EiFixBaseProxy_GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetNoPrimeTipsTrans()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSplashCDNOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSplashCDNClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFullScreenAnimOver()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipFullScreenAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowOptionalDownloadInfo(List<ResourceID> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
