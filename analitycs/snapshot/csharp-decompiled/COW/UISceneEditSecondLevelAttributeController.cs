using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UISceneEditSecondLevelAttributeController : UIPopupWindowController
{
	private UIHudSceneEditFuncAttributeSettingView m_View;

	private List<EJAOBJCGLKD.JNHDMBBECJP> mSecondLevelAttributeList;

	private Dictionary<string, ItemEditAttributeCacheValue_V2> mCachedValue;

	private UISceneEditSecondLevelAttributeTable mTableController;

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

	public void RefreshItemInfo(List<EJAOBJCGLKD.JNHDMBBECJP> slAttributes)
	{
	}

	private void RefreshUI()
	{
	}

	private void OnBtnResetClick()
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
}
