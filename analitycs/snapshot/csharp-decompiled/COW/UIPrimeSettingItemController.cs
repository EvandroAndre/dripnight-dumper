using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimeSettingItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIPrimeSettingItemView m_View;

	private uint m_PrivilegeId;

	private UIModelPrime m_ModelPrime;

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

	private void OnSelectBtnChanged()
	{
	}

	public void SetViewData(uint privilegeId)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
