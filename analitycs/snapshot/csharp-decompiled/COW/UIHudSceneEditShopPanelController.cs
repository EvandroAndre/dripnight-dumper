using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditShopPanelController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIHudSceneEditShopPanelController _003C_003E4__this;

		public BCCFKGIEFPI item;

		public int price;

		internal void _003COnPriceBtnClick_003Eb__0(int u)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIHudSceneEditShopPanelController _003C_003E4__this;

		public BCCFKGIEFPI item;

		public int totalLimit;

		internal void _003COnTotalLimitBtnClick_003Eb__0(int u)
		{
		}
	}

	private UIHudSceneEditShopPanelView m_View;

	private UIHudSceneEditShopChosenPanelController m_ShopChosenCtrl;

	private UIHudSceneEditNumInputWindowController m_NumInputCtrl;

	private List<UIHudSceneEditShopShelfController> m_CachedShelfCtrls;

	private UIHudSceneEditShopShelfAddController m_ShelfAddCtrl;

	private LHFNKEDKCBK m_ShopEditor;

	private string m_BindShopID;

	private UIHudSceneEditShopItemController.EShopItemOp m_CurSelectedOp;

	private Dictionary<string, bool> m_ShelfShowHidState;

	private Action m_CloseCallBack;

	private string m_PrevText;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnPriceBtnClick()
	{
	}

	private void OnTotalLimitBtnClick()
	{
	}

	private void OnTotalLimitToggle(UIToggleButton selectButton)
	{
	}

	public void SetShopData(LHFNKEDKCBK editor, string data, Action callBack = null)
	{
	}

	private void ShopItemChanged(object[] data)
	{
	}

	private void RefreshUI(object[] data)
	{
	}

	private void OnShelfShowHide(object[] data)
	{
	}

	private void OnItemChosen(object[] data)
	{
	}

	private void OnShopItemSelect(object[] data)
	{
	}

	private void OnCreateNewShelfClick()
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

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
