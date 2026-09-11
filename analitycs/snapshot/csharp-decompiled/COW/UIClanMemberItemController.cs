using GCommon;

namespace COW;

internal class UIClanMemberItemController : UIClanBaseItemController, IUIModelDataChangeObserver
{
	private UIClanMemberItemView m_View;

	private UIModelClan m_ModelClan;

	private UIModelUser m_ModelUser;

	private UIModelFriends m_ModelFriends;

	private ClanMember m_ClanMember;

	private bool m_IsExpanded;

	private new int m_Index;

	private int m_BGWidth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	private void OnAddFriendClick()
	{
	}

	private void OnBtnManageClick()
	{
	}

	private void SetExpandState()
	{
	}

	private void RefreshData()
	{
	}

	private void RefreshPrivilegeTag()
	{
	}

	public void SetBGInfo(int bgWidth)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
