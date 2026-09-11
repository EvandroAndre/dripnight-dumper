using System;
using GCommon;
using proto;

namespace COW;

public class UIDrawShopLimitedRewardItemController : UIBaseController
{
	protected UIDrawShopLimitedRewardItemView m_View;

	protected DrawShopPoolItemData m_ItemData;

	protected int m_Index;

	protected uint m_DrawShopId;

	protected Action<int> m_OnClickFunc;

	protected UIModelDrawShop m_ModelDrawShop;

	protected DrawShopLimitedPoolChangeSkinDesc m_SkinDesc;

	protected uint m_DropAnimDelayCall;

	protected uint m_SetGrayDelayCall;

	public int Index => 0;

	public DrawShopPoolItemData ItemData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public UIWidget GetClickableWidget()
	{
		return null;
	}

	public void InitOnClickFunc(Action<int> onClickFunc)
	{
	}

	public void PlayDropAndRebackAnim(bool isDrop, bool inRewardPool)
	{
	}

	protected virtual void OnBtnTipClick()
	{
	}

	public void SetViewInfo(uint drawShopId, int index, DrawShopPoolItemData itemData)
	{
	}

	public void RefreshItemDisplay()
	{
	}

	protected virtual void SetBaseItemView()
	{
	}

	protected virtual void SetSpecialIcon()
	{
	}

	public virtual void UpdateItemState()
	{
	}

	public void SetDropState(bool drop)
	{
	}

	private void CancelAllDelayCalls()
	{
	}

	protected virtual bool IsItemInPendingBuyList(DrawShopPoolItemData itemData)
	{
		return false;
	}

	protected virtual bool IsRewardRemoved(DrawShopPoolItemData itemData)
	{
		return false;
	}

	protected virtual int GetItemQuality(uint itemId)
	{
		return 0;
	}

	protected virtual void SetQualityDisplay()
	{
	}

	private string GetQualityBgCdnUrl(uint quality, bool isRareItem)
	{
		return null;
	}

	private void SetQualityBgFromCdn(string cdnUrl)
	{
	}

	private void SetQualityBgFromSprite(uint quality, bool isRareItem)
	{
	}

	public void ShowByViewState(EDrawShopItemViewStage stage, bool isGray = false)
	{
	}

	private void ShowNormalVfx(bool show)
	{
	}

	private void StopAllVFX()
	{
	}

	private void ShowReturnItemIfOwned()
	{
	}

	private void SetOwnedChangeItemDisplay(uint ownedChangeItemType, uint ownedChangeItemId, uint ownedChangeItemNum)
	{
	}

	private void _003CPlayDropAndRebackAnim_003Eb__18_0()
	{
	}

	private void _003CSetDropState_003Eb__25_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
