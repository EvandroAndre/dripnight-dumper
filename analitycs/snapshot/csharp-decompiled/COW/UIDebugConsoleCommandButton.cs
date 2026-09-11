using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleCommandButton : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public bool needChangeColor;
	}

	public delegate void OnRunCmd(string cmd);

	private UIDebugConsoleCommandBtnView m_View;

	private Data m_Data;

	private Color clickedColor;

	private bool hasClicked;

	public OnRunCmd OnRunCmdHandler;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public Data GetData()
	{
		return null;
	}

	public void SetData(Data data)
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

	public void UpdateColor()
	{
	}

	public void UpdateClickedState()
	{
	}

	public void SetClickedState(bool state)
	{
	}

	private void OnCmdClick()
	{
	}

	private void OnShowDebugUI(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
