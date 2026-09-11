using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILuckWheelRewardPoolItemController : UIBaseController
{
	private UILuckWheelRewardPoolItemView m_View;

	private CSLuckyWheelShopItemDesc m_RewardItem;

	private UIModelLuckyWheel m_Model;

	private UIModelGacha m_ModelGacha;

	private UILuckyWheelPreviewRewardPoolItemController m_ItemCtrl;

	private uint m_Price;

	private bool m_CanBuyItem;

	public bool ForceFullScreenPreview;

	private uint m_DelayCall;

	private Vector3 m_OriginalPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(CSLuckyWheelShopItemDesc rewardItem, bool needRefreshAnim = false)
	{
	}

	private void SetStandItemMiniData(CSLuckyWheelShopItemDesc rewardItem)
	{
	}

	private void AddEventDelegate()
	{
	}

	private void RefreshBuyBtnState()
	{
	}

	private void RefreshCoinIcon()
	{
	}

	private void RefreshPrice()
	{
	}

	private void RefreshTag()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	public void PlayUnLockVfx()
	{
	}

	public void HideUnLockVfx()
	{
	}

	public void PlayAnimation(CSLuckyWheelShopItemDesc desc)
	{
	}

	public void SkipAnimation()
	{
	}

	public void ResetAnimation()
	{
	}

	public void SetBuyBtnState(bool flag)
	{
	}

	private void _003COnBuyBtnClick_003Eb__20_0()
	{
	}

	private void _003CPlayAnimation_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
