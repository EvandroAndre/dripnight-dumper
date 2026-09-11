using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleProfileItemController : UIBaseController, UITable2.IUITable2Item
{
	private UILeaderBoardTitleProfileItemView m_View;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonController;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UILeaderBoardTitleProfileController m_ParentCtrl;

	private int m_Index;

	private uint m_TitleID;

	private ELeaderBoardTitleType m_TitleType;

	private UILeaderBoardTitleProfileController ParentCtrl => null;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(object data, int data_index)
	{
	}

	public void RefreshTitleEquip(bool isShow)
	{
	}

	private void OnSelectButtonClick()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetTransformPosX(int offestX, Transform transform)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
