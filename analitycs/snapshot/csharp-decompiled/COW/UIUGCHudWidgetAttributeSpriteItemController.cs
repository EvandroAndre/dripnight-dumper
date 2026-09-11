using System;
using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeSpriteItemController : UIEasyListItemController
{
	public Action<int> onSelected;

	private UIUGCHudWidgetAttributeSpriteItemView m_View;

	private float m_AutoFitMaxWidth;

	private float m_AutoFitMaxHeight;

	private string m_SpriteName;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void OnItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
