using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UICupMatchTeamProfileOtherController : UICupMatchTeamProfileController, IUIModelDataChangeObserver
{
	private ulong m_TeamID;

	private CupTeamInfo m_TeamInfo;

	private List<UIModelCupMatch.AccountInfoBasicWithCupInfo> m_TeamMemberInfo;

	private UIModelCupMatch m_ModelCupMatch;

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

	public void SetViewData(uint teamID, int key)
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
