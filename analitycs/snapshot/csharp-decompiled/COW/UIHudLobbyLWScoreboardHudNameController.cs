using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbyLWScoreboardHudNameController : UIBaseController
{
	private UIHudLobbyLWScoreboardHudNameView m_View;

	private UIHudLobbyLWScoreboardController m_ScoreboardCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(byte zoneIndex)
	{
	}

	public void SetWorldPosition(Vector3 worldPos)
	{
	}

	private void CreateScoreboardChild()
	{
	}

	private void ResolveBattleAreaPosition(byte zoneIndex)
	{
	}

	private bool TryApplyConfigWorldPosition()
	{
		return false;
	}

	private static bool TryParseVector3(string config, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	public void ShowEmpty(byte zoneIndex)
	{
	}

	public void ShowDefender(byte zoneIndex, uint defenderPlayerID)
	{
	}

	public void ShowBattle(byte zoneIndex, uint player1ID, uint player2ID)
	{
	}

	public void ShowResult(byte zoneIndex, uint player1ID, uint player2ID, uint winnerPlayerID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
