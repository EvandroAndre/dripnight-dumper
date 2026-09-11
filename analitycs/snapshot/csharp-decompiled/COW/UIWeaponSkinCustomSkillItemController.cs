using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomSkillItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIWeaponSkinCustomSkillItemView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private uint m_SkinId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetViewData(object data, int data_index)
	{
	}

	private void RefreshIcon()
	{
	}

	private void RefreshSkillDescribe()
	{
	}

	public void RefreshEquipState()
	{
	}

	private void ItemBtnClick()
	{
	}

	protected override void OnUIDestory()
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
