using GCommon;
using proto;

namespace COW;

public class UIChampionshipTeamProfileOtherController : UIChampionshipTeamProfileController, IUIModelDataChangeObserver
{
	private UIChampionshipTeamProfileView m_View;

	private ulong m_TeamID;

	private TeamInfo m_TeamInfo;

	private TeamMemberListWithAccountInfo m_TeamMemberInfo;

	private UIModelChampionship m_ModelChampionship;

	private CSTeamMatchStatsHistoryRes m_TeamMatchStatsHisotryRes;

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

	public void SetViewData(uint championshipType, uint teamID)
	{
	}

	private void UpdateTeamInfoView()
	{
	}

	private void UpdateTeamMemberView()
	{
	}

	public void SetBtnStatus()
	{
	}

	public void ShowMembers()
	{
	}

	public void ShowRecord()
	{
	}

	private void RecordDetail()
	{
	}

	private void RequestData()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
