using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class TrainingMiniGameDataManager : SingletonModule<TrainingMiniGameDataManager>
{
	private TrainingShootingGameData m_ShootingGameData;

	private TrainingIceWallPracticeData m_IceWallPracticeData;

	private TrainingGrenadePracticeData m_GrenadePracticeData;

	private Dictionary<uint, ServerMiniGameData> m_ServerMiniGameDataDict;

	private TrainingBillBoardData m_BillBoardData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public TrainingBillBoardData GetBillBoardData()
	{
		return null;
	}

	public TrainingShootingGameData GetShootingGameData()
	{
		return null;
	}

	public TrainingIceWallPracticeData GetIceWallPracticeData()
	{
		return null;
	}

	public TrainingGrenadePracticeData GetGrenadePracticeData()
	{
		return null;
	}

	public ServerMiniGameData GetMiniGameDataByGameType(MGAHNNBLGHN gameType)
	{
		return null;
	}

	public ResourceID GetMiniGameEffectRes(MGAHNNBLGHN gameType, int effectId)
	{
		return default(ResourceID);
	}
}
