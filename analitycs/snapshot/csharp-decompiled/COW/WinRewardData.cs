using message;
using proto;

namespace COW;

public class WinRewardData
{
	public uint WinPassStage;

	public DLBMPCCFKKM MatchMode;

	public float StartValue;

	public float EndValue;

	public AwardDesc WinReward;

	public float CurWinNum;

	public bool IsFirstReward;

	public bool IsLastReward;

	public ERanking.WinPassStatus ClaimedStatu;

	public bool IsSelected;
}
