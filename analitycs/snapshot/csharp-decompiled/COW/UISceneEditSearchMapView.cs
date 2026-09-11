using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditSearchMapView : UIBaseView
{
	public UIPanel RootPanel;

	public UITable RootTable;

	public UIWidget SearchBox;

	public UIWidget SearchHistory;

	public UIWidget HotSearch;

	public UIWidget HotMap;

	public UIInput SearchInput;

	public UIButton BtnSearch;

	public UITableWithBorder SearchHistoryTable;

	public UIGrid HotSearchGrid;

	public UIGrid HotMapGrid;

	public UIWidget SearchedItems;

	public UIGrid SearchedItemsGrid;

	public UIButton BtnLeave;

	public UIButton BtnRefreshHotSearch;

	public UIButton BtnResetSearchHistory;

	public GameObject SearchSucceededRoot;

	public GameObject SearchFailedRoot;

	public UILabel SearchedItemCountText;

	public UIButton BtnHelp;

	public UIButton BtnClearSearch;

	public UIScrollView SearchedItemsScroll;

	public UIButton BtnQRCodeScan;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
