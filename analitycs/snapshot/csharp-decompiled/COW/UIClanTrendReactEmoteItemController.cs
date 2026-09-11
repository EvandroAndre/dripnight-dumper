using GCommon;

namespace COW;

internal class UIClanTrendReactEmoteItemController : UIBaseController
{
	private UIClanTrendReactEmoteItemView m_View;

	private ChatStickerData m_ChatData;

	private int m_EmoteLimit;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(ChatStickerData chatStickerData)
	{
	}

	private bool CheckEmoteCanReply()
	{
		return false;
	}

	private bool CheckPlayerHaveReactThisEmote()
	{
		return false;
	}

	private void OnEmoteBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
