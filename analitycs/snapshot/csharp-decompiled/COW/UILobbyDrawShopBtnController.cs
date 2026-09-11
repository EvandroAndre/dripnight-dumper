using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UILobbyDrawShopBtnController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public uint entranceType;

		internal void _003CRefreshLobbyDrawShopEntrance_003Eb__0()
		{
		}
	}

	private UILobbyDrawShopBtnView m_View;

	private UICountDownController m_LobbyDrawShopCountDownCtrl;

	private List<UINetworkTexture> m_CDNIconList;

	private UIModelDrawShop m_ModelDrawShop;

	public uint LobbyDrawShopId;

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

	public void SetCDNIcon()
	{
	}

	private List<string> GetLobbyEntranceCdnList(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return null;
	}

	private string GetLobbyEntranceAnimClipName(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return null;
	}

	private string GetLobbyEntranceBubbleCdn(UIModelDrawShop.DrawShopContentDataBase contentData, out string language)
	{
		language = null;
		return null;
	}

	private string GetLobbyEntranceVfx(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return null;
	}

	public void SetCDNBubble()
	{
	}

	public void SetVFX()
	{
	}

	public void SetViewData(uint lobbyDrawShopId)
	{
	}

	public void RefreshLobbyDrawShopEntrance()
	{
	}

	public bool ShowLobbyDrawShopIntroIfNeed()
	{
		return false;
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	public void ResetLobbyDrawShopBubble()
	{
	}

	public bool IsLobbyDrawShopBubbleCanShow()
	{
		return false;
	}

	private void OnUILobbyDrawShopBtnClick()
	{
	}

	private void _003CSetCDNIcon_003Eb__10_0()
	{
	}

	private void _003CSetCDNBubble_003Eb__15_0()
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
