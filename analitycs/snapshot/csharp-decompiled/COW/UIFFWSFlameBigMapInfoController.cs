using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIFFWSFlameBigMapInfoController : UIBaseController
{
	private UIFFWSFlameBigMapInfoView m_View;

	private Dictionary<BHGGAEEHJCO, UIBigmapFFWSFlagTeammateView> m_BigmapFFWSFlagTeammateViews;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPlayerFFWSFlagChange(object[] data)
	{
	}

	private void ShowFFWSFlag()
	{
	}

	private void OnTeamKillCountChange(int teamId, int count)
	{
	}

	public void ShowTeammateInfo()
	{
	}

	private void UpdateTeamKillCount()
	{
	}

	private UIBigmapFFWSFlagTeammateView CreateTeammateView()
	{
		return null;
	}

	private int OnItemSort(Transform x, Transform y)
	{
		return 0;
	}

	public virtual void OnAddPlayer(GEvent param)
	{
	}

	private Player GetLocalOrFriendTrackPlayer()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
