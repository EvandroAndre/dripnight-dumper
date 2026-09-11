using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCMyWorksMapChecklistController : UIPopupWindowController
{
	public delegate bool CheckDoneCallback();

	public class ItemData
	{
		public string Title;

		public string Description;

		public EventDelegate.Callback GotoCallback;

		public CheckDoneCallback CheckDoneCallback;
	}

	private UIUGCMyWorksMapChecklistView m_View;

	private List<ItemData> m_ItemDatas;

	private List<ItemData> m_DoneItemDatas;

	private List<ItemData> m_NotDoneItemDatas;

	private List<UIUGCMyWorksMapChecklistItemController> m_ItemControllers;

	private UIUGCMyWorksController m_MyWorksController;

	private ItemData m_ExpandedItemData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMyWorksController(UIUGCMyWorksController controller)
	{
	}

	private void OrderAndShowItems()
	{
	}

	public void SetExpand(ItemData itemData)
	{
	}

	private void RefreshExpand()
	{
	}

	private void RefreshRank()
	{
	}

	private void OnBtnLeave()
	{
	}

	private bool _003COnUIInit_003Eb__10_0()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_1()
	{
	}

	private bool _003COnUIInit_003Eb__10_2()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_3()
	{
	}

	private bool _003COnUIInit_003Eb__10_4()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_5()
	{
	}

	private bool _003COnUIInit_003Eb__10_6()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_7()
	{
	}

	private bool _003COnUIInit_003Eb__10_8()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_9()
	{
	}

	private bool _003COnUIInit_003Eb__10_10()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_11()
	{
	}

	private bool _003COnUIInit_003Eb__10_12()
	{
		return false;
	}

	private void _003COnUIInit_003Eb__10_13()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
