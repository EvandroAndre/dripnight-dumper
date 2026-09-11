using GCommon;

namespace COW;

internal class UIHudPDMLeaderBoardItemController : UIHUDSingleFightLeaderBoardItemBaseController
{
	public static bool TargetScoreReachSoonPlayed;

	private byte m_TargetScore;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool ShowDeadBg()
	{
		return false;
	}

	public override void SetRank(uint rank)
	{
	}

	protected void OnTargetScoreChange(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ShowDeadBg()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetRank(uint P0)
	{
	}
}
