using System;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIEcoSettingShopItemController : UIBaseController
{
	public enum EShopOp
	{
		EShopOpAdd,
		EShopOpExisted
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__8_0;

		internal void _003COnEditBtnClick_003Eb__8_0()
		{
		}
	}

	private UIEcoSettingShopItemView m_View;

	private EShopOp m_Op;

	private LHFNKEDKCBK m_ShopEditor;

	private GKMLGCGLJKP m_BindData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(LHFNKEDKCBK editor, GKMLGCGLJKP data, EShopOp op, int width)
	{
	}

	private void OnEditBtnClick()
	{
	}

	private void OnDelBtnClick()
	{
	}

	private void OnCopyBtnClick()
	{
	}

	private void OnAddBtnClick()
	{
	}

	public bool IsTargetShopItem(string shopID)
	{
		return false;
	}

	public UIWidget GetBindWidget()
	{
		return null;
	}

	private void _003COnDelBtnClick_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
