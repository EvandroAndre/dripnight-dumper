using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPresetAgentFastMessagePanelController : UIBaseController
{
	private UIPresetAgentFastMessagePanelView m_View;

	private List<UIPresetAgentFastMessageItemController> m_ItemControllers;

	private const int BG_WIDTH_OFFSET = 28;

	private const int BG_HEIGHT_OFFSET = 20;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIWidget GetMaskWidget()
	{
		return null;
	}

	private void RefreshView()
	{
	}

	private void RefreshBGWithActualSizes()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
