using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopUnlimitedTokenWheelContentController : UIDrawShopContentBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__25_0;

		public static Comparison<DrawShopWheelExchangeDesc> _003C_003E9__49_0;

		internal void _003CInitCGReplayNodes_003Eb__25_0()
		{
		}

		internal int _003CRefreshExChangeBigAward_003Eb__49_0(DrawShopWheelExchangeDesc a, DrawShopWheelExchangeDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public GameObject cdnObject;

		public GameObject localObject;

		public Action successAction;

		internal void _003CSetLocalCdnImage_003Eb__0()
		{
		}
	}

	private UIDrawShopUnlimitedTokenWheelContentView m_View;

	private UIModelDrawShop.DrawShopWheelContentData m_ContentData;

	private UIDrawShopUnlimitedTokenWheelAwardItemBigController m_ExchangeItemBigController;

	private List<UIDrawShopUnlimitedTokenWheelAwardItemBaseController> m_ExchangeItemMidCtrlList;

	private List<UIDrawShopUnlimitedTokenWheelAwardItemSmallController> m_ExchangeItemSmallCtrlList;

	private UIDrawShopUnlimitedCardPoolController m_CardPoolController;

	private UIDrawShopUnlimitedBuyBtnController m_BuyController;

	private uint m_CurrentSelectedPoolAwardIndex;

	private const string COMMON_IN_UIFX = "UIFX_DRAWSHOPWHEEL_COMMON_IN";

	private const string BR_BLOODMOON26_IN_UIFX = "UIFX_BRBLOODMOON26_TRANSITION";

	private const string BR_NINTH_IN_UIFX = "UIFX_BRNINTH_ADMISSION";

	private const string BR_NINTH_CHEST_CONTAINER_BURST_UIFX = "UIFX_BRNINTH_CHESTCONTAINER_BURST";

	private const string BR_NINTH_CHEST_CONTAINER_LOOP_UIFX = "UIFX_BRNINTH_CHESTCONTAINER_LOOP";

	private GameObject m_ExchangeBtnVFXInstance;

	private GameObject m_BigAwardVFXInstance;

	private ResourceID m_InVFXResId;

	private ResourceID m_ChestContainerVFXResId;

	private ResourceID m_ChestContainerBurstVFXResId;

	private ResourceID m_ChestContainerLoopVFXResId;

	private ResourceID m_ExchangeBtnVFXResId;

	private ResourceID m_BigAwardVFXResId;

	private uint m_LastToken1Count;

	private UICommonGuideController m_NoItemSelectedGuideCtrl;

	private GameObject m_TitleVFXInstance;

	private ResourceID m_TitleVFXResId;

	protected Transform BuyContainer => null;

	protected Transform CardPoolContainer => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCGReplayNodes()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void InitBuyButtons()
	{
	}

	protected virtual UIDrawShopUnlimitedBuyBtnController OpenBuyController()
	{
		return null;
	}

	protected virtual UIDrawShopUnlimitedCardPoolController OpenCardPoolController()
	{
		return null;
	}

	private void LoadContentData()
	{
	}

	protected override void OnRefreshContentUI()
	{
	}

	public void ShowPreview(uint itemID = 0u)
	{
	}

	public void ShowPreview(BaseItemInfo itemInfo)
	{
	}

	private uint GetDefaultPreviewItemID()
	{
		return 0u;
	}

	public override void ResetToDefaultPreview()
	{
	}

	public override void OnAnimationComplete()
	{
	}

	protected override UIDrawShopUnlimitedCardPoolController GetCardPoolController()
	{
		return null;
	}

	private void RefreshTitle()
	{
	}

	private void RefreshTitleVFX()
	{
	}

	private void DestroyTitleVFX()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void RefreshBG()
	{
	}

	private void RefreshExChangeBigAward()
	{
	}

	private UIDrawShopUnlimitedTokenWheelAwardItemBaseController GetOrCreateMidAwardItemController(int index, Transform parentTransform)
	{
		return null;
	}

	private UIDrawShopUnlimitedTokenWheelAwardItemBaseController CreateMidAwardItemController(Transform parentTransform, bool useIconPlateItem)
	{
		return null;
	}

	private bool IsMidAwardItemControllerMatch(UIDrawShopUnlimitedTokenWheelAwardItemBaseController controller, bool useIconPlateItem)
	{
		return false;
	}

	private bool ShouldUseIconPlateAwardItem()
	{
		return false;
	}

	private void RefreshBigAwardCDNBG()
	{
	}

	private void RefreshExchangeBtn()
	{
	}

	private void RefreshCardPool()
	{
	}

	private void RefreshBuyBtnState()
	{
	}

	private void OnCardPoolItemSelected(object[] param)
	{
	}

	protected override UIWidget GetContentPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetContentPreviewType()
	{
		return FrontendPreviewType.Lobby;
	}

	public override Transform GetPrimeCountDownPos()
	{
		return null;
	}

	public override Transform GetNoPrimeTipsTrans()
	{
		return null;
	}

	public override void OnContentShow()
	{
	}

	public override void OnContentClose()
	{
	}

	public override GameObject GetTimeContainsObject()
	{
		return null;
	}

	public override GameObject GetGuaranteedDropObject()
	{
		return null;
	}

	public override GameObject GetBuyButtonObject()
	{
		return null;
	}

	private void UpdateExChangeBigAwardState()
	{
	}

	private void UpdateExchangeBtnState()
	{
	}

	private void UpdateCardPoolState()
	{
	}

	private void ClearCardPoolSelectedState()
	{
	}

	private void RefreshCardPoolAnimationDisplay(bool isSingle, uint index)
	{
	}

	private void RefreshCardPoolImmediateWithFlash(bool isSingle, uint index)
	{
	}

	private void StopCardPoolAnimationDisplay()
	{
	}

	private void RefreshGuaranteedDropDisplay()
	{
	}

	private void RefreshTokenProgressDisplay()
	{
	}

	public override void OnDrawSuccess(object[] param)
	{
	}

	public override void OnTokenUpdated()
	{
	}

	public override void OnItemOwnershipStateChanged()
	{
	}

	public override void OnTokenRewardClaimed(object[] param)
	{
	}

	private void OnNoItemSelected(object[] param)
	{
	}

	private void ShowNoItemSelectedGuide()
	{
	}

	private void CloseNoItemSelectedGuide()
	{
	}

	private void RefreshExchangeButtonBGSkin()
	{
	}

	private void RefreshExchangeBtnVFX()
	{
	}

	private void RefreshBigAwardVFX()
	{
	}

	private void RefreshInVFX()
	{
	}

	private void TriggerInVFXLoad()
	{
	}

	private string GetInVFXName()
	{
		return null;
	}

	private void RefreshChestContainerVFX()
	{
	}

	private void TriggerChestContainerVFXLoad()
	{
	}

	private void DestroyChestContainerVFX()
	{
	}

	private void RefreshChestContainerNinthVFX()
	{
	}

	private bool IsBRNinthSkin()
	{
		return false;
	}

	private void ApplyHelperVFX(VFXCreateHelper helper, string vfxName, ref ResourceID cachedResId)
	{
	}

	private void DestroyHelperVFX(VFXCreateHelper helper, ref ResourceID cachedResId)
	{
	}

	private void SetLocalCdnImage(GameObject localObject, GameObject cdnObject, UINetworkTexture cdnTexture, string cdnUrl, Action successAction = null)
	{
	}

	private DrawShopWheelChangeSkinDesc GetChangeSkinDesc()
	{
		return null;
	}

	private string GetChangeSkinCDNUrl(string cdnUrl)
	{
		return null;
	}

	private void ApplyChangeSkinVFX(GameObject container, string vfxName, ref GameObject vfxInstance, ref ResourceID cachedResId)
	{
	}

	private ResourceID GetChangeSkinVFXResourceID(string vfxName)
	{
		return default(ResourceID);
	}

	private void DestroyChangeSkinVFX(ref GameObject vfxInstance, ref ResourceID cachedResId)
	{
	}

	private void DestroyInVFX()
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	protected override void OnRewardWindowClosed(object[] param)
	{
	}

	private void CheckAndPlayTokenChangeVFX()
	{
	}

	private void SyncToken1CountSnapshot()
	{
	}

	private void PlayTokenChangeVFX()
	{
	}

	public override void OnSkipDrawAnimation()
	{
	}

	public override void OnAnimEvent(object[] param)
	{
	}

	protected override void TryShowContentGuide()
	{
	}

	private void ShowWheelGuideStep1()
	{
	}

	private void ShowWheelGuideStep2()
	{
	}

	private void ShowWheelGuideStep3()
	{
	}

	private void ShowWheelGuideStep4()
	{
	}

	protected override uint[] GetCarouselModelIds()
	{
		return null;
	}

	protected override float GetCarouselInterval()
	{
		return 0f;
	}

	protected override void ShowCarouselPreview(uint itemId)
	{
	}

	private void _003CRefreshTitle_003Eb__42_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__47_0()
	{
	}

	private void _003CRefreshCountDownLabel_003Eb__47_1()
	{
	}

	private void _003CRefreshBigAwardCDNBG_003Eb__54_0()
	{
	}

	private void _003CRefreshBigAwardCDNBG_003Eb__54_1()
	{
	}

	private void _003CShowNoItemSelectedGuide_003Eb__82_0()
	{
	}

	private void _003CRefreshExchangeButtonBGSkin_003Eb__84_0()
	{
	}

	private void _003CShowWheelGuideStep1_003Eb__112_0()
	{
	}

	private void _003CShowWheelGuideStep2_003Eb__113_0()
	{
	}

	private void _003CShowWheelGuideStep3_003Eb__114_0()
	{
	}

	private void _003CShowWheelGuideStep4_003Eb__115_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetToDefaultPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnimationComplete()
	{
	}

	public UIDrawShopUnlimitedCardPoolController _003C_003EiFixBaseProxy_GetCardPoolController()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetPrimeCountDownPos()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetNoPrimeTipsTrans()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnContentShow()
	{
	}

	public void _003C_003EiFixBaseProxy_OnContentClose()
	{
	}

	public GameObject _003C_003EiFixBaseProxy_GetTimeContainsObject()
	{
		return null;
	}

	public GameObject _003C_003EiFixBaseProxy_GetGuaranteedDropObject()
	{
		return null;
	}

	public GameObject _003C_003EiFixBaseProxy_GetBuyButtonObject()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnDrawSuccess(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTokenUpdated()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemOwnershipStateChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTokenRewardClaimed(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnRewardWindowClosed(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSkipDrawAnimation()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAnimEvent(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_TryShowContentGuide()
	{
	}

	public uint[] _003C_003EiFixBaseProxy_GetCarouselModelIds()
	{
		return null;
	}

	public float _003C_003EiFixBaseProxy_GetCarouselInterval()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_ShowCarouselPreview(uint P0)
	{
	}
}
