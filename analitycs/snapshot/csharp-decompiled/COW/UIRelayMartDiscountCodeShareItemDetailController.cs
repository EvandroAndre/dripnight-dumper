using GCommon;
using tcp;

namespace COW;

public class UIRelayMartDiscountCodeShareItemDetailController : UIBaseController, IUIModelDataChangeObserver
{
	private UIRelayMartDiscountCodeShareItemDetailView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private ulong m_LastBtnClickTime;

	private FastRelayMartDiscountCodeShareMessage m_Message;

	private bool m_HasClickGoToBtn;

	private EChannel.ChannelType m_RecvType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetUIData(FastRelayMartDiscountCodeShareMessage message, string nickName = "", EChannel.ChannelType recvType = EChannel.ChannelType.ChannelType_MAX)
	{
	}

	private void OnGoToBtnClick()
	{
	}

	private void OnGoToSelfBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
