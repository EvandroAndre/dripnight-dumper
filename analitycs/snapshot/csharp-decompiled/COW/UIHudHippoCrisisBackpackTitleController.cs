using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisBackpackTitleController : UIBaseController, UITable2.IUITable2Item
{
	private UIHudHippoCrisisBackpackTitleView m_View;

	private bool m_IsBackpackTitle;

	private Color ProgressBarDefaultColor;

	private uint SafeBoxBgDefaultHeight;

	public bool IsInTableSafeBoxTitle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnTipClick()
	{
	}

	void UITable2.IUITable2Item.SetPosition(Vector2 position)
	{
	}

	object UITable2.IUITable2Item.SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetData(bool isBackpackTitle, EventDelegate.Callback onExpandBtnClick = null)
	{
	}

	public void RefreshUI()
	{
	}

	void UITable2.IUITable2Item.SetTable2Visible(bool visible)
	{
	}

	public override GameObject GetViewRootObject()
	{
		return null;
	}

	public Vector2 GetWidgetV2()
	{
		return default(Vector2);
	}

	public UIWidget GetWidget()
	{
		return null;
	}

	private void OnTitleClick()
	{
	}

	public void SetInTableSafeBg(int alltemHeight)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public GameObject _003C_003EiFixBaseProxy_GetViewRootObject()
	{
		return null;
	}
}
