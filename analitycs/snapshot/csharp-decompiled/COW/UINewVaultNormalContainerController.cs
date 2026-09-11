using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewVaultNormalContainerController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private UINewVaultNormalContainerView m_View;

	private Func<Transform, UIEasyListItemController> m_funcOpenItemController;

	private Action<UIEasyListItemController> m_FuncCloseItemController;

	private UIModelGroup m_ModelGroup;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(Func<Transform, UIEasyListItemController> func, Action<UIEasyListItemController> closeItemCB)
	{
	}

	public UIEasyList GetEasyList()
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void ShowAni()
	{
	}

	private void RefreshSetShareLock()
	{
	}

	private void OnRelseaseLockClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetScrollView(float sizeY)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
