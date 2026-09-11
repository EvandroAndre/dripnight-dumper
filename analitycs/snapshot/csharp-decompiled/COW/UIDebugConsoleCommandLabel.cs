using GCommon;
using UnityEngine;

namespace COW;

internal class UIDebugConsoleCommandLabel : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;
	}

	private UIDebugConsoleCommandLabelView m_View;

	private Data m_Data;

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

	public void SetText(string text)
	{
	}

	public void SetTextWidth(int width)
	{
	}

	public void SetTextHeight(int height)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
