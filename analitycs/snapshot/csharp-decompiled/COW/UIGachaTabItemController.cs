using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaTabItemController : UIBaseController
{
	private UIGachaTabItemView m_View;

	private GachaDesc m_Desc;

	private GameObject m_RoyalVFX;

	private GameObject m_NewBieVFX;

	public ulong startTime;

	public int pageDetentionTime;

	private int m_Idx;

	private bool m_IsSelected;

	private UIModelGacha m_ModelGacha;

	private UIModelIchis m_ModelIchis;

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

	protected override void OnUIDestroy()
	{
	}

	public void OnUIGachaShow()
	{
	}

	public void OnUIGachaHide()
	{
	}

	public void SetViewData(int curGachaIdx)
	{
	}

	private void RefreshPrimeState()
	{
	}

	private void RefreshDiscountTag()
	{
	}

	private void RefreshIchisDiscountTag()
	{
	}

	public void RefreshUI()
	{
	}

	private void OnGachaTabItemBtnClick()
	{
	}

	public void SetSelecetState(bool isSelected, bool forceRefresh = false)
	{
	}

	private void InitCDNTex()
	{
	}

	private void RefreshNewTip()
	{
	}

	public void EnableRoyaleVFX()
	{
	}

	public void EnableLuckySpinVFX()
	{
	}

	public void EnableNewBieVFX()
	{
	}

	private void _003CInitCDNTex_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
