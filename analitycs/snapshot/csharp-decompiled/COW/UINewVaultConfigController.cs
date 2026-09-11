using System;
using GCommon;

namespace COW;

internal class UINewVaultConfigController : UIBaseController
{
	private UINewVaultConfigView m_View;

	private Action m_OnClose;

	private UIModelCollection m_modelCollection;

	private bool m_IsBagShowInOtherGameMode;

	private bool m_IsBagShowLobby;

	private bool m_IsBagShowInCSGame;

	private int m_ItemId;

	private UIModelNewVault m_ModelNewVault;

	private const int stdWidth = 386;

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

	public void SetViewData(Action onClose)
	{
	}

	public void CloseWithItemid(int item)
	{
	}

	private void OnClickMaskClick()
	{
	}

	private void OnShowInLobbyBtnClick()
	{
	}

	private void OnShowInOtherGameModeClick()
	{
	}

	private void OnShowInCSGameModeClick()
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
}
