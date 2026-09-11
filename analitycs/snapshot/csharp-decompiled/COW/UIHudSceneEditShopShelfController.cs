using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditShopShelfController : UIBaseController
{
	private UIHudSceneEditShopShelfView m_View;

	private List<UIHudSceneEditShopItemController> m_CachedItemCtrls;

	private LHFNKEDKCBK m_ShopEditor;

	private string m_BindShopID;

	private string m_BindShelfID;

	private string m_PrevText;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetShelfData(LHFNKEDKCBK editor, string shelfID, string shopID, bool initShow)
	{
	}

	private void RefreshUI(object[] data)
	{
	}

	private void OnShowBtnClick()
	{
	}

	private void OnHideBtnClick()
	{
	}

	private void OnDelBtnClick()
	{
	}

	private void OnRenameBtnClick()
	{
	}

	private void OnGetFocus()
	{
	}

	private void OnLostFocus()
	{
	}

	private void _003COnDelBtnClick_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
