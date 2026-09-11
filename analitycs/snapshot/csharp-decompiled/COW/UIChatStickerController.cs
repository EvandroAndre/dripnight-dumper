using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIChatStickerController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ChatStickerPrice> _003C_003E9__18_0;

		internal int _003CRefreshStickerView_003Eb__18_0(ChatStickerPrice a, ChatStickerPrice b)
		{
			return 0;
		}
	}

	private UIChatStickerView m_View;

	private uint m_CurrentSelectSticker;

	private List<StickerSpriteView> m_StickerSpriteViewList;

	private List<StickerTabView> m_StickerTabViewList;

	private bool m_HasInitSticker;

	private UIModelChat m_ModelChat;

	private UIChatBottomLeftController m_ParentCtrl;

	private UIChatBottomLeftController ParentCtrl => null;

	private ChatChannelInfo m_CurShowChannel => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnStickerTabClick(object[] data)
	{
	}

	private void OnStickerSpriteClick(object[] data)
	{
	}

	private void OnStickerPurchaseBtnClick()
	{
	}

	private void PurchaseSticker()
	{
	}

	private void OnCloseStickerBtnClick()
	{
	}

	public void RefreshStickerView()
	{
	}

	private void UpdateStickerList(uint itemid)
	{
	}

	public void UpdatePanelDepth(int depth)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
