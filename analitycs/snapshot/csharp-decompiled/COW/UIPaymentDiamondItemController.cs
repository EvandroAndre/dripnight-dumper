using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentDiamondItemController : UIBaseController
{
	private UIPaymentDiamondItemView m_View;

	private Color selectedColor;

	private Color lockedColor;

	private PaymentDiamondItemData m_Info;

	private UIModelPayment m_Model;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ResetState()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(object data, int index)
	{
	}

	private void PlayEffectAndSound(object[] data)
	{
	}

	private void AfterAnimPlayed(object[] data)
	{
	}

	private void OnButtonClicked()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
