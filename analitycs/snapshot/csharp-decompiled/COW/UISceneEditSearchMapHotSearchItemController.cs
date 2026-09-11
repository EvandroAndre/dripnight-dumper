using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISceneEditSearchMapHotSearchItemController : UIBaseController
{
	private UISceneEditSearchMapHotSearchItemView m_View;

	private string m_SearchContent;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(WorkshopHotSearchConfigDesc desc)
	{
	}

	public void AddCallback(EventDelegate.Callback callback)
	{
	}

	public string GetSearchContent()
	{
		return null;
	}

	public Vector2 GetSize()
	{
		return default(Vector2);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
