using GCommon;
using tcp;

namespace COW;

internal class UILobbyV2GameAssistantWishItemController : UILobbyV2GameAssistNormalItemController
{
	private UILobbyV2GameAssistantWishItemView m_View;

	private WishItemOutputInfoNtf m_Info;

	private UIStandardItemMAXBController m_ItemCtrl;

	private CSSharedItemData m_ItemInfo;

	private ChannelGoposSummaryData m_GoposData;

	private WishlistOutItemChannelInfo m_ChannelInfo;

	private UIModelGameAssistantIntroduction m_ModelGameAssist;

	private UIModelWishList m_ModelWishList;

	private long m_EndTime;

	private bool m_HasAllChannelExpired;

	public new static ResourceID GetResourceID()
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

	protected override void SetRead()
	{
	}

	private void RefreshItemIcon()
	{
	}

	private void RefreshItemDesc()
	{
	}

	private void RefreshItemGoPos()
	{
	}

	private void RefreshItemSign()
	{
	}

	private void OnChannelGotoBtnClick()
	{
	}

	private void SetItemData(ChannelGoposSummaryData data)
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void _003CRefreshItemSign_003Eb__19_0()
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

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
