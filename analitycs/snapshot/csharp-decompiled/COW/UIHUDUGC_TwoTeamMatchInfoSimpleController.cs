using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeamMatchInfoSimpleController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_TwoTeamMatchInfoSimpleView m_View;

	private UGCTwoTeamMatchInfoSimpleHudRepItem m_ViewData;

	private Color Blue;

	private Color Red;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnLeftTeamScoreChanged(int cur)
	{
	}

	private void OnRightTeamScoreChanged(int cur)
	{
	}

	private void OnLeftTeammateAliveCountChanged(int cur)
	{
	}

	private void OnRightTeammateAliveCountChanged(int cur)
	{
	}

	private void OnLeftIconSpriteNameChanged(string cur)
	{
	}

	private void OnRightIconSpriteNameChanged(string cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
