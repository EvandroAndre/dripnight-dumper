using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCustomCollectionBigEventItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIProfileCustomCollectionBigEventItemView m_View;

	private UIModelAchievement m_Model;

	private UIModelProfile m_ModelProfile;

	private UIModelProfileCustom m_ModelProfileCustom;

	private List<AchievementEntryInfo> m_CompletedInfo;

	private ProfileCustomBigEventEquippedData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnBigEventPreviewBtn()
	{
	}

	private void OnEditBtnClick()
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
