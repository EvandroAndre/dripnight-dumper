using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaUnlimitedChestBuyBtnController : UIGachaBuyBtnController, ILuckySpinButton
{
	private UIGachaUnlimitedChestBuyBtnView m_UnlimitedBtnView;

	private Vector3 m_OneBuyBtnPos;

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

	public void RefreshLuckySpinBtn(bool isLuckySpin)
	{
	}

	public UIWidget GetTenBuyBtnWidget()
	{
		return null;
	}

	public UIButton GetTenBuyBtn()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshBuyBtn()
	{
	}
}
