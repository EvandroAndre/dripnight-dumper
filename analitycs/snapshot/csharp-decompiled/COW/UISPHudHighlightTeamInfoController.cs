using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudHighlightTeamInfoController : UIBaseController
{
	private UISPHudHighlightTeamInfoView m_View;

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

	public void SetData(byte teamId, string teamName, Color teamColor)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
