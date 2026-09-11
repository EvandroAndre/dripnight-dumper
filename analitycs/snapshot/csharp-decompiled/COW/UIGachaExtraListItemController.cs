using GCommon;
using proto;

namespace COW;

public class UIGachaExtraListItemController : UIBaseController
{
	public enum ExtraAwardItemState
	{
		STATE_NONE,
		STATE_ALREADY_RECEIVE,
		STATE_CAN_RECEIVE,
		STATE_CANNOT_RECEIVE
	}

	private UIGachaExtraListItemView m_View;

	private UIModelGacha m_ModelGacha;

	private UIGachaExtraRewardItemController m_MiniCtrl;

	private ExtraAwardItemState m_State;

	private ExtraRewardDesc m_ItemDesc;

	private int m_Indx;

	private uint m_GachaID;

	private uint m_ItemDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetData(ExtraRewardDesc data, int data_index, uint chestID)
	{
	}

	public void UpdateItemState()
	{
	}

	private void SetDefaultUI()
	{
	}

	private void RefreshExtraAwardItem(uint chestID, bool isFirstReward)
	{
	}

	public void OnItemBtnSelect()
	{
	}

	private void _003COnItemBtnSelect_003Eb__17_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
