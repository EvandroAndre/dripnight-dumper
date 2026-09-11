using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditFuncAttributeSettingController : UIPopupWindowController
{
	private UIHudSceneEditFuncAttributeSettingView m_View;

	private FKMEPHCOMIG m_Data;

	private SceneEditObjectAttrBase curAttr;

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string CustomTitle()
	{
		return null;
	}

	public void SetUGCAttributeSettingUIData(FKMEPHCOMIG data)
	{
	}

	private void BuildChildComponent(Transform container, IModeEditComponentData data)
	{
	}

	private void UpdateDepths(Transform subObject, int depth)
	{
	}

	private void OnBtnResetClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnEnterGetter(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
