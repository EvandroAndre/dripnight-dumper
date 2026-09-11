using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudPresetPickEntranceController : UIBaseController
{
	private UIHudPresetPickEntranceView m_View;

	private Dictionary<int, string> m_PresetIconNameMap;

	private bool m_HasAutoOpenPresetPick;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitPresetIconNameMap()
	{
	}

	private void RefreshPresetInfo(bool needRefreshUIFX)
	{
	}

	private void RefreshPresetIDView(int presetID)
	{
	}

	private void OnEntranceBtnClick()
	{
	}

	public bool ShowTutorial()
	{
		return false;
	}

	public void OnCSShopHide()
	{
	}

	private void TryAutoOpenPresetPick()
	{
	}

	private void StopCurrentTutorial()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
