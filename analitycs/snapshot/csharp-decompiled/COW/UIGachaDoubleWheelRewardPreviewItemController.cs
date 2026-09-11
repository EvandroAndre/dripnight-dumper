using GCommon;
using proto;

namespace COW;

public class UIGachaDoubleWheelRewardPreviewItemController : UIBaseController
{
	private UIGachaDoubleWheelRewardPreviewItemView m_View;

	private UIStandardItemMAXBController m_ItemController;

	private GachaShowItem m_GachaShowItem;

	private BaseItemInfo m_Data;

	private UIModelGacha m_ModelGacha;

	private bool m_IsItemABReady;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void SetViewData(GachaShowItem gachaShowItem)
	{
	}

	protected void RefreshItemView()
	{
	}

	private void ResetState()
	{
	}

	private void CheckItemABReady()
	{
	}

	private void RefreshItemBGState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
