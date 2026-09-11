using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIIVTWBuyBtnController : UIGachaBuyBtnController, ILuckySpinButton
{
	private UIGachaIIV1_TWIIVBuyBtnView m_UnlimitedBtnView;

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
