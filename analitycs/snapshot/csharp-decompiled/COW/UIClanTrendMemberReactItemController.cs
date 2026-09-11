using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIClanTrendMemberReactItemController : UIBaseController
{
	private UIClanTrendMemberReactItemView m_View;

	private ChatStickerData m_ChatData;

	private ulong m_MessageTrendId;

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

	public void SetVFXShow(bool show)
	{
	}

	public void SetViewData(uint emojiId, List<ulong> replyIdList, ulong messageId, bool showVfx = false)
	{
	}

	private void OnReactBtnClick()
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
