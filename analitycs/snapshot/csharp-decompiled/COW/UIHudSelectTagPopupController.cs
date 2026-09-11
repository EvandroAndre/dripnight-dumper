using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudSelectTagPopupController : UIPopupWindowController
{
	private UIHudSelectTagPopupView m_View;

	private UIModelKolHud m_ModelKolHud;

	private int m_HudUploadIndex;

	private int m_tagLimit;

	private Dictionary<uint, UIHudSelectTagItemController> m_TagControllerList;

	private List<uint> m_SelectedTags;

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

	private void InitAllTags()
	{
	}

	private void RefreshView()
	{
	}

	public void SetData(int hudUploadIndex)
	{
	}

	private void OnClickTag(uint index)
	{
	}

	private void OnClickConfirm()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
