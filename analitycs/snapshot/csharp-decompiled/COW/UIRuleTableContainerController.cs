using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIRuleTableContainerController : UIBaseController
{
	private UIRuleTableContainerView m_View;

	public CTableContainerData Data;

	public Action DimensionsChanged;

	public int OriginalHeight;

	public int SelfPaddingY;

	public bool AutoBgExtension;

	public int CustomBgExtension;

	public bool ShouldRepostion;

	protected UIModeEditGeneralComponentHelper m_GeneralHelper;

	protected List<Transform> m_Components;

	protected float m_Width;

	protected float m_ChildWidth;

	protected float m_ExtendedHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void ShowTutorial()
	{
	}

	public void OnShowTutorialHandler()
	{
	}

	public void SetViewData(CTableContainerData data, float width, float height, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	protected virtual UIBaseController BuildChildComponent(Transform container, IModeEditComponentData data)
	{
		return null;
	}

	public void AddDimensionsChanged(Action callback)
	{
	}

	public void AddEnableChanged(Action callback)
	{
	}

	protected void Reposition()
	{
	}

	public void RecalculateHeight()
	{
	}

	private void LateUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
