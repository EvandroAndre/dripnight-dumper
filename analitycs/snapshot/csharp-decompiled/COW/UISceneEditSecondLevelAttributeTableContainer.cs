using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISceneEditSecondLevelAttributeTableContainer : UIBaseController
{
	private UIRuleTableContainerView m_View;

	public EJAOBJCGLKD.JNHDMBBECJP mData;

	public int OriginalHeight;

	public int SelfPaddingY;

	public int curDepth;

	public int CellWidth;

	public float TablePaddingY;

	public int ContainerPaddingX;

	public int ButtomPaddingY;

	protected List<UIBaseController> m_Components;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	public void SetViewData(EJAOBJCGLKD.JNHDMBBECJP data, float width, int depth, bool isLastOne)
	{
	}

	protected virtual UIBaseController BuildChildComponent(Transform container, ItemEditAttributeUIData_V2 uiData, float paddingY)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
