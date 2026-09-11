using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UILobbyV2TeamLimitTipsController : UIPopupWindowController
{
	private UILobbyV2TeamLimitTipsView m_View;

	private UIModelGroup m_ModelGroup;

	private readonly Color SoftIsolationIconColor;

	private readonly Color HardIsolationIconColor;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void SetViewData()
	{
	}

	public void SetPosition(Vector3 worldPosition)
	{
	}

	public void SetLocalPosition(Vector3 localPositionOffset)
	{
	}

	private void RefreshText()
	{
	}

	private string GetTeamRankLimitRuleTipDesc()
	{
		return null;
	}

	private void RefreshRankIcons()
	{
	}

	private void RefreshIconColor()
	{
	}

	private void GetTeamRankRangeMembers(out GroupMemberInfo lowRankMember, out GroupMemberInfo highRankMember)
	{
		lowRankMember = null;
		highRankMember = null;
	}

	private uint GetMemberRankByMatchMode(GroupMemberInfo member)
	{
		return 0u;
	}

	private ResourceID GetMemberRankIconByMatchMode(GroupMemberInfo member, uint matchMode)
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
