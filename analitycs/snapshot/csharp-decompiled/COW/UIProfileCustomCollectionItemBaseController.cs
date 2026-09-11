using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIProfileCustomCollectionItemBaseController : UIBaseController, UITable2.IUITable2Item
{
	protected Vector3 m_Table2ItemOffset;

	protected UIProfileCustomController ProfileCustomNaviCtrl;

	public ProfileCustomModuleData CustomModuleData;

	protected bool m_InEditScene;

	protected bool m_InBriefBox;

	protected bool m_IsSelf;

	protected ProfileDataPunishSwitchConfig m_ProfileDataPunishConfig;

	public int ModuleID => 0;

	protected override void OnUIInit()
	{
	}

	protected abstract ProfileCustomDragDropItem GetDragDropItem();

	public abstract GameObject GetIcon();

	public void InitItemConfig(bool inBriefBox, bool inEditScene, bool isSelf, ProfileCustomDragTemplate template, UIDragDropItem.Restriction restriction = UIDragDropItem.Restriction.Horizontal)
	{
	}

	public void SetProfileDataPunishConfig(ProfileDataPunishSwitchConfig config)
	{
	}

	protected void SendItemClickEvent()
	{
	}

	protected void SendItemDeleteEvent()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	protected virtual void CaclulateItemOffset()
	{
	}

	public virtual void SetViewData(ProfileCustomModuleData data)
	{
	}

	public virtual void ShowBgByBriefBox()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
