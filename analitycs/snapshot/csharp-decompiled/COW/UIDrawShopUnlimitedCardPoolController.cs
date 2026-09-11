using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedCardPoolController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public UINetworkTexture cdnTexture;

		internal void _003CRefreshCDNTexture_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UIDrawShopUnlimitedCardPoolController _003C_003E4__this;

		public uint index;

		internal void _003CRefreshCardPoolAnimationDisplay_003Eb__0()
		{
		}

		internal void _003CRefreshCardPoolAnimationDisplay_003Eb__1()
		{
		}
	}

	protected UIDrawShopUnlimitedCardPoolViewSetting m_ViewSetting;

	protected UIDrawShopCommonCardPoolShowController m_cardPoolShowController;

	protected UIModelDrawShop m_ModelDrawShop;

	protected uint m_DrawShopId;

	protected UIModelDrawShop.EDrawShopType m_DrawShopType;

	private string m_CardPoolCardBGCDNUrl;

	private string m_CardPoolCardBGVFXCDNUrl;

	protected string m_CardPoolCardTableUpCDNUrl;

	protected string m_CardPoolCardTableDownCDNUrl;

	protected string m_CardPoolCardTableVFXCDNUrl;

	protected string m_ChestName;

	protected uint[] m_AwardDataList;

	protected Dictionary<uint, UIDrawShopUnlimitedCardPoolItemController> m_AwardItemCtrlDict;

	protected UIModelDrawShop.DrawShopContentDataBase m_ContentData;

	private UIModelDrawShop.EDrawShopWheelCustomType m_CardPoolShowCustomType;

	private Dictionary<uint, Transform> m_PoolItemTransformDict;

	private string m_CardPoolTopBG1CDNUrl;

	private string m_CardPoolTopBG2CDNUrl;

	private const float CARD_ANIMATION_INTERVAL = 0.2f;

	private const float CARD_POOL_ANIMATION_DELAY = 0.5f;

	private uint m_RefreshAllCardDelayCall;

	private uint m_RefreshAllCardIndex;

	private uint m_CardPoolAnimDelayCall;

	private bool m_IsAnimationPlaying;

	private bool m_IsCurrentAnimSingle;

	private uint m_CurrentAnimSingleIndex;

	private string m_ExpectedNormalInFinishEvt;

	private string m_ExpectedBigInFinishEvt;

	private string m_CurrentCardPoolAnimClip;

	private bool m_IsPlayingEntranceAnim;

	private uint m_EntranceAnimDelayCall;

	private uint m_EntranceAnimIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitPoolItemTransformDict()
	{
	}

	public Transform GetPoolItemTransform(uint index)
	{
		return null;
	}

	public void SetViewData(UIModelDrawShop.DrawShopContentDataBase contentData, bool isRefreshAllUI = true)
	{
	}

	private void RefreshAllUI()
	{
	}

	protected virtual void SetCommonData(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	private void RefreshChangeSkin()
	{
	}

	protected virtual void CreatCardPoolShowUI()
	{
	}

	protected virtual UIModelDrawShop.EDrawShopWheelCustomType GetCardPoolShowCustomType()
	{
		return UIModelDrawShop.EDrawShopWheelCustomType.Common;
	}

	protected virtual UIDrawShopCommonCardPoolShowController OpenCardPoolShowController(UIModelDrawShop.EDrawShopWheelCustomType customType)
	{
		return null;
	}

	protected virtual void RefreshTopCardPoolBG()
	{
	}

	public void RefreshCDNTexture(UINetworkTexture cdnTexture, string cdnUrl)
	{
	}

	private string GetChangeSkinCDNUrl(string cdnUrl, string language)
	{
		return null;
	}

	private void RefreshVFX()
	{
	}

	private void RefreshAwardList()
	{
	}

	public virtual void RefreshAwardByIndex(uint index)
	{
	}

	protected virtual UIDrawShopUnlimitedCardPoolItemController OpenCardPoolItemController(Transform parentTransform)
	{
		return null;
	}

	protected virtual bool TryGetGoodsInfo(uint goodsId, out BaseItemInfo itemInfo, out bool isRemove, out bool isRare, out UIModelDrawShop.RepeatChangeItemInfo repeatChangeInfo)
	{
		itemInfo = null;
		isRemove = default(bool);
		isRare = default(bool);
		repeatChangeInfo = null;
		return false;
	}

	protected virtual void OnTitleClick()
	{
	}

	public void ClearSelectedState()
	{
	}

	public void RefreshCardPoolAnimationDisplay(bool isSingle, uint index)
	{
	}

	public virtual string GetGrandPrizeAnimationClip01()
	{
		return null;
	}

	public virtual string GetGrandPrizeAnimationClip02()
	{
		return null;
	}

	private void RefreshSingleCard(uint index)
	{
	}

	private void RefreshOtherItemStates(uint excludeIndex)
	{
	}

	public void RefreshAllItemStates()
	{
	}

	private void RefreshAllCard()
	{
	}

	private void DoRefreshNextCard()
	{
	}

	private void CancelRefreshAllCardDelayCall()
	{
	}

	private void CancelCardPoolAnimDelayCall()
	{
	}

	private void CancelEntranceAnimDelayCall()
	{
	}

	public bool IsPlayingEntranceAnimation()
	{
		return false;
	}

	public void HideAllItemsForEntrance()
	{
	}

	public void PlayPoolEntranceAnimation()
	{
	}

	private void DoPlayNextEntranceAnim()
	{
	}

	public void StopEntranceAnimationDisplay()
	{
	}

	public void StopCardPoolAnimationDisplay()
	{
	}

	public void RefreshCardPoolImmediateWithFlash(bool isSingle, uint index)
	{
	}

	private void RefreshAllAwardsWithFlash()
	{
	}

	private void RefreshAwardByIndexWithFlash(uint index)
	{
	}

	private void SetAllItemsMaskActive(bool active)
	{
	}

	private void SetSingleItemMaskActive(uint index, bool active)
	{
	}

	public void SkipToLastFrameOfCardPoolAnimation()
	{
	}

	private void OnAnimEvtOccur(object[] param)
	{
	}

	private void NotifyAnimationEnd(bool isEntranceAnim = false)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CRefreshChangeSkin_003Eb__25_0()
	{
	}

	private void _003CPlayPoolEntranceAnimation_003Eb__66_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
