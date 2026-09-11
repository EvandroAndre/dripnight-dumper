using GCommon;
using proto;

namespace COW;

internal class UIGachaCouponTipsController : UIEasyListItemController
{
	private UIGachaCouponTipsView m_View;

	private UIStandardItemMAXBController m_ItemController;

	private Item m_ItemData;

	private OnFinished m_OnCountDownFinished;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Refresh()
	{
	}

	public void SetViewData(Item itemData, bool canChoose = true, bool staticTime = true)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetStaticTime()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private void SetDynamicTime()
	{
	}

	public void SetCountDownFinishedAction(OnFinished action)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
