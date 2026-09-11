using GCommon;

namespace COW;

public class UIChampionshipTeamJoinItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIChampionshipTeamJoinItemView m_View;

	private UIModelChampionship m_ModelChampionship;

	private FriendAccountInfo m_AccountInfo;

	private UIChampionshipTeamJoinController m_Parent;

	private uint m_ChampionshipType;

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

	public void SetChampionshipType(uint championshipType)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void LookOver()
	{
	}

	private void ApplyFor()
	{
	}

	private void UpdateApplyButtonView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
