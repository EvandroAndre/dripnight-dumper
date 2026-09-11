using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewKeyActionContentController : UIBaseController
{
	private UINewKeyActionContentView m_View;

	public List<UINewKeyActionItemController> ItemCtrList;

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

	public UINewKeyActionItemController CreateKeyActionItem(KeyActionSettingData setData)
	{
		return null;
	}

	public void RefreshWidget()
	{
	}

	public void SetTitle(int type)
	{
	}

	public bool ExistConflictKeyCode(KeyCode keyCode, string actionName, ref string conflictName)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
