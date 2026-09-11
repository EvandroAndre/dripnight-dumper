using GCommon;
using UnityEngine;

namespace COW;

public class UISH_GachaBuyBtnController : UIGachaBuyBtnController, ILuckySpinButton
{
	private UISH_GachaBuyBtnView m_UnlimitedBtnView;

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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshBuyBtn()
	{
	}
}
