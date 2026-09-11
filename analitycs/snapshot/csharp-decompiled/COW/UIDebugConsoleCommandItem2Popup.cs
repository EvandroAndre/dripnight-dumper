using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleCommandItem2Popup : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public string name;

		public string cmd;

		public string arg1Name;

		public string arg2Name;

		public Dictionary<string, List<string>> argValueMap;

		public string arg1InitValue;

		public string arg2InitValue;

		public PopUpStyle style;

		public Action pop2ClickedAction;

		public int depth;
	}

	public delegate void OnRunCmd(string cmd, string arg1, string arg2);

	private UIDebugConsoleCommandItem2PopupView m_View;

	private Data m_Data;

	private UIPopMenuSmallControler m_Arg1Popup;

	private UIPopMenuSmallControler m_Arg2Popup;

	private string m_CurArg1Value;

	private string m_CurArg2Value;

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

	public void SetTable2Visible(bool visible)
	{
	}

	public void UpdateCurPopMenus(List<string> list)
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

	private void OnCmdClick()
	{
	}

	private PopMenuData _003COnArg1PopupClick_003Eb__15_0(string item)
	{
		return null;
	}

	private PopMenuData _003COnArg2PopupClick_003Eb__17_0(string item)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
