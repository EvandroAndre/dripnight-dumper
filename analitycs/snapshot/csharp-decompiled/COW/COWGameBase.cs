using GCommon;

namespace COW;

public abstract class COWGameBase : BaseGame
{
	public enum GameType
	{
		FrontEndGame,
		MultiPlayerGame,
		SinglePlayerGame,
		TutorialGame,
		HotUpdaterGame,
		SceneEdit
	}

	public enum GameSubType
	{
		None,
		WaitingGame,
		BattleGame,
		SceneEditGame
	}

	public enum GameModeType
	{
		All,
		PVP,
		PVE
	}

	public enum GameMode : uint
	{
		GameModeNone = 0u,
		GameModeBattleRoyale = 1u,
		GameModeSpeedRoyale = 2u,
		GameModeFateRoyale = 3u,
		GameModeSpeedRoyaleZombie = 4u,
		GameModeBattleRoyaleZombie = 7u,
		GameModePurge = 12u,
		GameModeSnowMan = 25u,
		GameModeReborn = 13u,
		GameModeCS = 15u,
		GameModeTK = 22u,
		GameModeTDM = 24u,
		GameModeTraining = 23u,
		GameModeWerewolves = 37u,
		GameModeReaper = 30u,
		GameModeGiant = 29u,
		GameModeTutorialBR = 40u,
		GameModeTutorialCS = 41u,
		GameModeHardCoreCS = 52u,
		GameModeSingerB = 56u,
		GameModeInfection = 58u,
		GameModeFootball = 64u,
		GameModeMetropolis = 79u,
		GameModeFPPCS = 82u,
		GameModeSOCIAL = 62u,
		GameModeHippoCrisis = 88u,
		GameModeHippoCrisisTutorial = 89u
	}

	public static bool IsMatchGame()
	{
		return false;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected void AdJustUMAGarbgeRate()
	{
	}

	protected override bool GetNeedUseOptEventDispatcher()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_GetNeedUseOptEventDispatcher()
	{
		return false;
	}
}
