using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditShopShelfAddController : UIBaseController
{
	private UIHudSceneEditShopShelfAddView m_View;

	private LHFNKEDKCBK m_ShopEditor;

	private string m_BindShopID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(LHFNKEDKCBK editor, string shopID)
	{
	}

	private void OnUIHudSceneEditShopShelfAddClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
