using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleCommandItem2 : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public string arg1Name;

		public string arg2Name;

		public string arg1Value;

		public string arg2Value;

		public string arg1ValueChangeCmd;

		public string arg2ValueChangeCmd;
	}

	public delegate void OnRunCmd(string cmd, string arg1, string arg2);

	private UIDebugConsoleCommandItem2View m_View;

	private Data m_Data;

	public OnRunCmd OnRunCmdHandler;

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

	public void SetTheArg1Visible(bool visible)
	{
	}

	public void SetTheArg2Visible(bool visible)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void OnCmdClick()
	{
	}

	private void OnArg1Change()
	{
	}

	private void OnArg2Change()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
