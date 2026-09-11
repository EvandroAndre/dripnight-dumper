using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISceneEditSecondLevelAttributeTable : UIBaseController
{
	private UIRuleVScrollTableContainerView m_View;

	private float m_Width;

	public List<EJAOBJCGLKD.JNHDMBBECJP> mDataList;

	private List<UISceneEditSecondLevelAttributeTableContainer> controllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<EJAOBJCGLKD.JNHDMBBECJP> data, float width, float height)
	{
	}

	private void BuildChildComponent(Transform container, int index, bool isLastOne)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
