using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditAirDropPanelController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<KeyValuePair<int, int>> _003C_003E9__22_0;

		internal int _003CTryGetDropItems_003Eb__22_0(KeyValuePair<int, int> a, KeyValuePair<int, int> b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int Num;

		public UIHudSceneEditAirDropPanelController _003C_003E4__this;

		internal void _003COnCountBtnClick_003Eb__0(int u)
		{
		}
	}

	private UIHudSceneEditAirDropPanelView m_View;

	private UIHudSceneEditShopChosenPanelController m_ShopChosenCtrl;

	private UIHudSceneEditNumInputWindowController m_NumInputCtrl;

	private UIHudSceneEditAirDropItemController.EShopItemOp m_CurSelectedOp;

	private int m_selectedMapIndex;

	private int m_selectedItemId;

	private string m_BindAirDropID;

	private Action m_CloseCallBack;

	private LHFNKEDKCBK m_ShopEditor;

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

	private void OnCountBtnClick()
	{
	}

	public void SetShopData(string airDropEntityId, Action callBack = null)
	{
	}

	private void ShopItemChanged(object[] data)
	{
	}

	private void RefreshUI(object[] data)
	{
	}

	private int GetAirDropItemNum(int itemId, int mapIdx)
	{
		return 0;
	}

	private bool SetAirDropItemNum(int itemId, int mapIdx, int value)
	{
		return false;
	}

	private void OnItemChosen(object[] data)
	{
	}

	private void OnDropItemRemove(object[] data)
	{
	}

	private void OnShopItemSelect(object[] data)
	{
	}

	private bool TryGetDropItems(out List<KeyValuePair<int, int>> dropItems)
	{
		dropItems = null;
		return false;
	}

	private void SetDropItems(List<KeyValuePair<int, int>> dropItems)
	{
	}

	private bool ContainsDropItem(List<KeyValuePair<int, int>> dropItems, int itemID)
	{
		return false;
	}

	private int FindDropItemIndex(List<KeyValuePair<int, int>> dropItems, int itemID)
	{
		return 0;
	}

	private bool TryConvertToInt(object value, out int result)
	{
		result = default(int);
		return false;
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
