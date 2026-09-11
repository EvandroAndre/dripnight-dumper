using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileDocumentRulePopWndController : UIPopupWindowController
{
	private List<UILobbyDotController> m_DotCtrls;

	private List<UIProfileDocumentRuleItemController> m_Items;

	private UIProfileDocumentRulePopWndView m_View;

	private UICenterOnChild m_wrapCenter;

	private UIDragScrollView m_Drag;

	private int m_LastSelectedMapIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitDots()
	{
	}

	private void InitTutorial()
	{
	}

	private void OnAutoScrollAdItem()
	{
	}

	public void ForceScrollToItem(int index)
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
