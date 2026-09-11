using GCommon;

namespace COW;

public class UICupMatchTeamInviteItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UICupMatchTeamInviteItemView m_View;

	private FriendAccountInfo m_FriendAccountInfo;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private UIModelCupMatch m_ModelCupMatch;

	private UICupMatchTeamInviteController m_Parent;

	private int m_CupMatchKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetCupMatchKey(int key)
	{
	}

	private void Invite()
	{
	}

	private void UpdateInviteButtonView()
	{
	}

	private void OnProfileClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
