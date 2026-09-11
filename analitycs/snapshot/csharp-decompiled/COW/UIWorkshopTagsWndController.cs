using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIWorkshopTagsWndController : UIPopupWindowController
{
	private UIWorkshopTagsWndView m_View;

	private UIModelSceneEdit m_Model;

	private SceneEditSlotInfo m_SlotInfo;

	private List<WorkshopTagType> m_DataList;

	private List<UIWorkshopTagsListController> m_ListControllers;

	private List<uint> m_SelectedTags;

	public Action<List<uint>> OnTagsChanged;

	public List<uint> SelectedTags => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string CustomTitle()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	public void RefreshViewData(SceneEditSlotInfo slotInfo)
	{
	}

	private void RefreshTagLists()
	{
	}

	private void RefreshBtn(bool hasSelected)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void AddTag(uint tagId)
	{
	}

	public void RemoveTag(uint tagId)
	{
	}

	public void ToggleTag(uint tagId)
	{
	}

	public bool IsTagSelected(uint tagId)
	{
		return false;
	}

	public void RepositionTable()
	{
	}

	public UIScrollView GetScrollView()
	{
		return null;
	}

	public void CollapseOtherLists(UIWorkshopTagsListController exceptList)
	{
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
