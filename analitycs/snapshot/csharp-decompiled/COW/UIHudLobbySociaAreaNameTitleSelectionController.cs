using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudLobbySociaAreaNameTitleSelectionController : UIBaseController, IEasyList
{
	private const int UseGridItemCountMax = 2;

	private const int SingleItemBgHeight = 144;

	private const int MultiItemBgHeight = 232;

	private UIHudLobbySociaAreaNameTitleSelectionView m_View;

	private UIModelLobbySocial m_ModelLobbySocial;

	private List<TitleSelectionItemData> m_DataList;

	private List<UIHudLobbySociaAreaNameTitleSelectionItemController> m_GridItemControllers;

	private ESocialHall.TitleType m_InitialChosenTitleType;

	private bool m_IgnoreInitialSelection;

	private bool m_UseGrid;

	private int m_GridLastClickIndex;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void ClearClickMask()
	{
	}

	public void Refresh(List<TitleSelectionItemData> titleList, ESocialHall.TitleType currentTitleType)
	{
	}

	private void ApplyInitialSelection()
	{
	}

	public void OnItemSelected(ESocialHall.TitleType titleType)
	{
	}

	public void OnSelectedItemClickedAgain()
	{
	}

	private void OnGridItemSelected(int index)
	{
	}

	private void ClearGridItems()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void CommitChoice(ESocialHall.TitleType chosenTitleType)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
