using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudPersonalGameShopController : UIHudInGameShopController
{
	private bool m_HaveBought;

	private UIDetailTipsInGameController m_DetailTips;

	private uint m_CurShopId;

	private bool m_IsHideTemporary;

	public uint CurShopId => 0u;

	protected override Dictionary<int, List<BGMFPPDLCBB>> ShopItems => null;

	protected override HEOJAGLBHLJ ShopType => HEOJAGLBHLJ.EShopType_Common;

	protected bool UseCoin => false;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnWarningPress(GameObject go, bool value)
	{
	}

	private void OnTitleHelpPress(GameObject go, bool value)
	{
	}

	protected override void InitSpecialEvent()
	{
	}

	private void RefreshBoughtState(bool show)
	{
	}

	private void HideTemporary()
	{
	}

	public void OnShowPersonalShopHud(object[] datas)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnBuyReqBuild(EDPFGIMHEPM req)
	{
	}

	protected override void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
	{
	}

	protected override int GetShowCoinValue()
	{
		return 0;
	}

	protected override void OnBgClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitSpecialEvent()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public Dictionary<int, List<BGMFPPDLCBB>> _003C_003EiFixBaseProxy_get_ShopItems()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnBuyReqBuild(EDPFGIMHEPM P0)
	{
	}

	public HEOJAGLBHLJ _003C_003EiFixBaseProxy_get_ShopType()
	{
		return HEOJAGLBHLJ.EShopType_Common;
	}

	public void _003C_003EiFixBaseProxy_GetOwnerInfo(ref int P0, ref int P1, ref int P2)
	{
	}

	public int _003C_003EiFixBaseProxy_GetShowCoinValue()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnBgClick()
	{
	}
}
