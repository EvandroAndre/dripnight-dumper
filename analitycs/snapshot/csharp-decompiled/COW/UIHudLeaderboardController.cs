using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudLeaderboardController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Transform> _003C_003E9__13_0;

		internal int _003CSort_003Eb__13_0(Transform item2, Transform item1)
		{
			return 0;
		}
	}

	private UIHudLeaderboardView m_View;

	private Dictionary<BHGGAEEHJCO, LeaderboardData> m_ItemsBe4LocalPlayer;

	private Dictionary<BHGGAEEHJCO, UIHudLeaderboardItemController> m_ItemControllers;

	private bool m_LocalPlayerAdded;

	private int m_LocalPlayerTeamId;

	private bool m_IsSPFactionUpdated;

	private ulong m_StartShowTime;

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

	private void OnBtnCloseClick()
	{
	}

	private void OnAddPlayer(GEvent param)
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void AddItemController(BHGGAEEHJCO pId, LeaderboardData dataInfo)
	{
	}

	private void Sort(BHGGAEEHJCO pId)
	{
	}

	private void OnKillCountChanged(object[] param)
	{
	}

	private void OnDeadCountChanged(object[] param)
	{
	}

	private void OnAssistCountChanged(object[] param)
	{
	}

	private void OnTotalDamageChanged(object[] param)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void OnFactionIDChanged(object[] param)
	{
	}

	private void UpdateFactionInfo()
	{
	}

	private void UpdateFactionInfo(int localFactionID)
	{
	}

	private void OnToggleRoundInfo(object[] parap)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
