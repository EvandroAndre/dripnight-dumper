using GCommon;

namespace COW;

public class UIChampionshipTeamInviteItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIChampionshipTeamInviteItemView m_View;

	private FriendAccountInfo m_FriendAccountInfo;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private UIModelChampionship m_ModelChampionship;

	private UIChampionshipTeamInviteController m_Parent;

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

	private void Invite()
	{
	}

	private void UpdateInviteButtonView()
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
