using GCommon;
using UnityEngine;

namespace COW;

internal class UIWorkshopGenreWndItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIWorkshopGenreWndItemView m_View;

	private UIModelSceneEdit m_Model;

	private WorkshopGenreID m_Data;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	private void RefreshMapIcon(string url)
	{
	}

	private void RefreshModeName()
	{
	}

	private void RefreshSelectedState()
	{
	}

	private void OnBtnClick()
	{
	}

	private void _003CRefreshMapIcon_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
