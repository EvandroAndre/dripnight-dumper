using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionPrivilegeIconController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomCollectionPrivilegeIconItemView m_View;

	private ProfileCustomPrivilegeIconData m_Data;

	private UIModelRole m_ModelRole;

	private UIModelProfile m_ModelProfile;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private string m_Tips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void OnBtnShowTipsClick()
	{
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}
}
