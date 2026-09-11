using GCommon;

namespace COW;

public class UICupMatchTeamJoinItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UICupMatchTeamJoinItemView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private FriendAccountInfoWithCupTeamInfo m_AccountInfoWithCupTeamInfo;

	private UICupMatchTeamJoinController m_Parent;

	private int m_CupMatchKey;

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

	public void SetCupMatchKey(int cupMatchKey)
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
