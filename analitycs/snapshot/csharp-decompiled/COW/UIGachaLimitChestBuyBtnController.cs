using GCommon;
using UnityEngine;

namespace COW;

internal class UIGachaLimitChestBuyBtnController : UIGachaBuyBtnController, ILuckySpinButton
{
	private UIGachaLimitChestBuyBtnView m_chestView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void InitBuyBtnBaseView()
	{
	}

	protected override void OnRefreshBuyBtn()
	{
	}

	protected override Color GetLimitLabelColor(uint chestID)
	{
		return default(Color);
	}

	public void RefreshLuckySpinBtn(bool isLuckySpin)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshBuyBtn()
	{
	}

	public Color _003C_003EiFixBaseProxy_GetLimitLabelColor(uint P0)
	{
		return default(Color);
	}
}
