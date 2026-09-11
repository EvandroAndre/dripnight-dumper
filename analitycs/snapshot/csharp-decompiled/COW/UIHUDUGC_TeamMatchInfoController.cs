using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TeamMatchInfoController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_TeamMatchInfoView m_View;

	private UGCTeamMatchInfoHudRepItem m_ViewData;

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

	private string GetText(string key, object[] param)
	{
		return null;
	}

	private void ShowScore()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnOffsetPositionChanged(Vector3 cur)
	{
	}

	private void OnRankChanged(int cur)
	{
	}

	private void OnTeamColorChanged(int cur)
	{
	}

	private void OnIconSpriteNameChanged(string cur)
	{
	}

	private void OnShowFrameChanged(bool cur)
	{
	}

	private void OnScoreTextKey_ParamsChanged(List<object> cur)
	{
	}

	private void OnScoreTextKeyChanged(string cur)
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
