using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGachaCouponInsufficientPopUpController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSSharedItemData, uint> _003C_003E9__14_0;

		internal uint _003CRefreshSourceChannel_003Eb__14_0(CSSharedItemData coupon)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIModelBigEvent.TokenTipsData sourceChannel;

		internal bool _003CRefreshSourceChannel_003Eb__3(UIModelBigEvent.TokenTipsData source)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UILabel label;

		public uint couponNeed;

		internal void _003CSetTokenText_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private UIGachaCouponInsufficientPopUpView m_View;

	private UIModelGacha m_ModelGacha;

	private uint m_GachaID;

	private UIModelGacha.GachaDrawType m_DrawType;

	private uint m_TokenID;

	private List<UIModelBigEvent.TokenTipsData> m_SourceChannelList;

	private List<UIGachaCouponInsufficientPopUpChannelItemController> m_SourceItemList;

	private bool m_IsCloseByGoto;

	public static uint FrameStyle;

	private const int MaxSourceChannelCount = 3;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override ResourceID GetFrameResourceId()
	{
		return default(ResourceID);
	}

	public void SetViewData(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
	}

	private void RefreshSourceChannel()
	{
	}

	private void SetTokenText(UILabel label, ResourceID iconRes, uint couponNeed)
	{
	}

	private void SetSymbolLabelAtlasInfo(UILabel label, ResourceID iconRes, uint couponNeed)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshSourceChannel_003Eb__14_1()
	{
	}

	private void _003CRefreshSourceChannel_003Eb__14_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetFrameResourceId()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
