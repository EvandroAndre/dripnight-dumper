using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudBlockEditEnumPopWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIHudBlockEditEnumPopItemController ctrl;

		public UIHudBlockEditEnumPopWndController _003C_003E4__this;

		internal void _003CSetView_003Eb__0()
		{
		}
	}

	private UIHudBlockEditEnumPopWndView m_View;

	private UIHudBlockEditEnumPopItemController m_CurrentItem;

	private Dictionary<string, List<UIHudBlockEditEnumPopItemController>> m_CatagoryDic;

	private UIPopMenuSmallControler m_PopCtrl;

	private List<PopMenuData> m_PopDatas;

	private string m_CurrentGroup;

	private UIGrid m_Grid;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnItemSelect(UIHudBlockEditEnumPopItemController select)
	{
	}

	public void SetView(EBEPopWndType type, List<BEPopWndItemData> datas, BEPopWndItemData current)
	{
	}

	private void OnPopEnumClick()
	{
	}

	private void OnCatagorySelect(object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
