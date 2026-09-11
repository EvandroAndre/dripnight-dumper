using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityStandardController : UIActivityBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public uint id;

		internal bool _003CSelectItem_003Eb__0(ActivityGroupDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UINetworkTexture networkTexture;

		internal void _003CSetSubBg_003Eb__1()
		{
		}
	}

	private UIActivityStandardView m_View;

	private List<ActivityGroupDesc> m_GroupDescs;

	private ActivityGroupDesc m_SelectedGroup;

	private ActivityGroupDesc m_LastEaterGroup;

	private UIActivityCollectionEventController m_LastEasterContent;

	private IUIActivityContent m_Content;

	private UIModelActivity m_ModelActivity;

	private UIModelFriendReunion m_ModelFriendReunion;

	private List<StandardTabItemViewData> m_TabDataList;

	private UIStandardTabController m_TabCtrl;

	private List<ActivityGroupDesc> m_GroupDescsOrgin;

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

	protected override void OnUIOpen()
	{
	}

	public override uint GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public void ActivityGroupSelected(int descIndex)
	{
	}

	public override void SetData(object data)
	{
	}

	public override void RefreshLeftTabData(object data)
	{
	}

	public void UpdateTabData(int tabIndex)
	{
	}

	public override void SelectItem(uint id, bool needScroll = true)
	{
	}

	public override void OnPanelDepthChanged()
	{
	}

	public override void Reload()
	{
	}

	public void UpdateSideGroup(uint groupId)
	{
	}

	private IUIActivityContent OpenActivityContent(ActivityGroupDesc desc)
	{
		return null;
	}

	protected IUIActivityContent OpenActivityADFullContent(ActivityGroupDesc desc)
	{
		return null;
	}

	private bool IsADFullTemplateStyle(uint actStyle)
	{
		return false;
	}

	private void SetSubBg(bool isADfull)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void CloseOldContent()
	{
	}

	public override void OnVisibilityChange(bool isVisible)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void OnPopUpWindowListChange(bool isCovered)
	{
	}

	private bool _003CReload_003Eb__22_0(ActivityGroupDesc e)
	{
		return false;
	}

	private bool _003CUpdateSideGroup_003Eb__23_0(ActivityGroupDesc e)
	{
		return false;
	}

	private bool _003CSetSubBg_003Eb__27_0(AdvertDesc e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshLeftTabData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SelectItem(uint P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPanelDepthChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopUpWindowListChange(bool P0)
	{
	}
}
