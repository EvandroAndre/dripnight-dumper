using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbySocialShowHideLobbyUIController : UIBaseController
{
	private UIHudLobbySocialShowHideLobbyUIView m_View;

	private bool m_IsLobbyUIVisible;

	private bool m_IsInNinthArea;

	private bool m_EnableImmersiveMode;

	public bool EnableImmersiveMode
	{
		set
		{
		}
	}

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

	private void RefreshNinthUIAlpha()
	{
	}

	private void OnShowHideBtnClick()
	{
	}

	public void EnterImmersiveMode()
	{
	}

	public void ExitImmersiveMode()
	{
	}

	private void SetNavControllerRootPanelAlpha(Component navCtrl, float alpha)
	{
	}

	private void RefreshView()
	{
	}

	private static void SetControllerRootPanelAlpha(Component ctrl, float alpha)
	{
	}

	private static UIPanel GetPanelFromController(Component ctrl)
	{
		return null;
	}

	private void OnNinthAreaStateChanged(uint data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
