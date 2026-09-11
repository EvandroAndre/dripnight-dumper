using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCustomCollectionAchievementPointController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomCollectionAchievementPointItemView m_View;

	private AchievementPointData m_Data;

	private UIModelAchievement m_Model;

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

	private void RefreshAchievementPointView()
	{
	}

	private void RefreshAchievementInfo(uint curType)
	{
	}

	private void RefreshAchievementCDN(EAchievement.Type curType)
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
