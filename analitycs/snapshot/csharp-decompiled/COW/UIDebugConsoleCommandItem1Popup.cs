using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIDebugConsoleCommandItem1Popup : UIBaseController, UITable2.IUITable2Item
{
	public enum ArgContainerType
	{
		None,
		Input,
		Popup
	}

	public class Data
	{
		public string cmd;

		public string cmdSp;

		public string arg1Name;

		public ArgContainerType arg1Container;

		public ArgContainerType arg2Container;

		public string defaultValue1;

		public string defaultValue2;

		public Dictionary<string, string> arg1ValueMap;

		public Dictionary<string, string> arg2ValueMap;

		public bool showBg;

		public bool adjustDepthOnShow;
	}

	public delegate void OnRunCmd(string cmd, string arg1, string arg2);

	private UIDebugConsoleCommandItem1PopupView m_View;

	private Data m_Data;

	private UIPopMenuSmallControler m_Arg1Popup;

	private UIPopMenuSmallControler m_Arg2Popup;

	private string m_CurArg1Value;

	private string m_CurArg2Value;

	public OnRunCmd OnRunCmdHandler;

	public OnRunCmd OnRunCmdSpHandler;

	public static int panelGroupDepth;

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

	private void OnArg1PopupClick()
	{
	}

	private void UpdateArg1Type(object targetArg1Type)
	{
	}

	private void OnArg2PopupClick()
	{
	}

	private void UpdateArg2Type(object targetArg2Type)
	{
	}

	private void GetInputValue()
	{
	}

	private void OnCmdClick()
	{
	}

	private void OnCmdSpClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
