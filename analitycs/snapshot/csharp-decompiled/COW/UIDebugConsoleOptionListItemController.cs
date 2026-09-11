using GCommon;

namespace COW;

public class UIDebugConsoleOptionListItemController : UIEasyListItemController
{
	public UIDebugConsoleOptionListController OptionListController;

	private UIDebugConsoleOptionListItemView m_View;

	private string m_Option;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void _003COnUIInit_003Eb__4_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
