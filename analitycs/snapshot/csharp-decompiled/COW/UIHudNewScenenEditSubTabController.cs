using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudNewScenenEditSubTabController : UIBaseController
{
	private UIHudNewSceneEditSubTabView m_View;

	private uint m_OptionID;

	private HNDHJGJILHC m_SceneEditGame;

	private bool m_IsSearchTab;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(WorkShopResourceTypeData subTabTypeData, bool isSearchTab)
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	public uint GetOptionID()
	{
		return 0u;
	}

	public void RefreshTabNew()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
