using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopTagsItemController : UIBaseController
{
	private const int LeftRightMarginSize = 14;

	private const int TopBottomMarginSize = 8;

	private UIWorkshopTagsItemView m_View;

	private UIWorkshopTagsWndController m_ParentWndController;

	private UIWorkshopTagsListController m_ParentListController;

	private WorkshopModeTagData m_TagData;

	private bool m_IsSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(WorkshopModeTagData data, UIWorkshopTagsWndController parentController, UIWorkshopTagsListController listController)
	{
	}

	public void SetViewData(WorkshopModeTagData data)
	{
	}

	private void RefreshView()
	{
	}

	public void RefreshSelectedState()
	{
	}

	private void OnTagClick()
	{
	}

	public void SetOverflowCount(int count)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void SetNormalBgColor(Color color)
	{
	}

	public void SetNormalTxtColor(Color color)
	{
	}

	public int GetWidth()
	{
		return 0;
	}

	private void UpdateBackgroundSize()
	{
	}

	private void UpdateSelectedVisual()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
