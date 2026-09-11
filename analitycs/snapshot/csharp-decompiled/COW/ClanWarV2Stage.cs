namespace COW;

public class ClanWarV2Stage
{
	public enum EStage
	{
		None,
		BeforeFirstSeason,
		SeasonTrans,
		SeasonPre,
		RoundTrans,
		WarmUp,
		Opening,
		Settling,
		SeasonEnding,
		Intermission
	}

	public static ClanWarV2Stage INVALID;

	private uint m_StageID;

	public ulong EndTimeStamp;

	public uint StageID => 0u;

	public uint Season => 0u;

	public uint Round => 0u;

	public EStage StageType => EStage.None;

	public ClanWarV2Stage(uint season, uint round, uint stage)
	{
	}

	public static uint ConvertToStageID(uint season, uint round, uint stage)
	{
		return 0u;
	}

	public override string ToString()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
