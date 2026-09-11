using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionTitleItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomCollectionTitleItemView m_View;

	private TitleInfo m_Data;

	private UITitleCommonController m_TitleCommonCtrl;

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

	public override void SetViewData(ProfileCustomModuleData data)
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

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	public override void ShowBgByBriefBox()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowBgByBriefBox()
	{
	}
}
