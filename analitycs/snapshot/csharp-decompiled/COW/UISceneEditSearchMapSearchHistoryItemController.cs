using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditSearchMapSearchHistoryItemController : UIBaseController
{
	private UISceneEditSearchMapSearchHistoryItemView m_View;

	private float m_DefaultLabelWidth;

	private Vector3 m_DefaultLabelPosition;

	private float m_DefaultPadding;

	private string m_SearchContent;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(string content)
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
