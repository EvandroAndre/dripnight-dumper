using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIWorkshopTagsListController : UIBaseController
{
	private UIWorkShopTagsListView m_View;

	private UIModelSceneEdit m_Model;

	private UIWorkshopTagsWndController m_ParentWndController;

	private WorkshopTagType m_TagTypeData;

	private List<WorkshopModeTagData> m_TagsData;

	private List<UIWorkshopTagsItemController> m_TagItemControllers;

	private bool m_IsExpanded;

	private int m_FirstRowCount;

	private bool HasMoreTags => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(WorkshopTagType tagTypeData, UIWorkshopTagsWndController parentController)
	{
	}

	private void RefreshTagItemsVisibility()
	{
	}

	public void RefreshTagTitle()
	{
	}

	private void RefreshViewBtn(bool hasMoreTags)
	{
	}

	private void RefreshAllTagItemsSelectedState()
	{
	}

	private void OnViewBtnClick()
	{
	}

	public int GetSelectedCountInCategory()
	{
		return 0;
	}

	public bool CanAddTagInCategory()
	{
		return false;
	}

	public int GetNumberLimit()
	{
		return 0;
	}

	public bool IsSingleSelectMode()
	{
		return false;
	}

	public void DeselectCurrentTagInCategory()
	{
	}

	public void Collapse()
	{
	}

	private void UpdateContainerSize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
