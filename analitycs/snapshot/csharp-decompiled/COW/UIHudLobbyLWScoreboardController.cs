using COW.GamePlay;
using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW;

public class UIHudLobbyLWScoreboardController : UIBaseController
{
	public enum ScoreboardState
	{
		Empty,
		Defender,
		Battle,
		Result
	}

	private UIHudLobbyLWScoreboardView m_View;

	private uint m_LeftPlayerID;

	private uint m_RightPlayerID;

	private uint m_WinnerPlayerID;

	private ScoreboardState m_CurrentState;

	private AudioPlaybackParams_Unity m_PlayParam;

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

	private void OnDisable()
	{
	}

	private void SetState(ScoreboardState state)
	{
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

	private void RefreshBattleInfo()
	{
	}

	private void RefreshBooyah()
	{
	}

	private void SetPlayerHead(UIEffectSprite headSprite, UINetworkTexture headIcon, GameObject fakeSprite, Player player)
	{
	}

	private void RefreshStreak(GameObject container, UILabel label, uint playerID)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void ApplyScoreFromPlayer(uint sourcePlayerID, int score)
	{
	}

	private void ApplyScore(byte leftWins, byte rightWins)
	{
	}

	private void PlayScoreUIFX()
	{
	}

	private void RefreshDefenderInfo(uint defenderPlayerID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
