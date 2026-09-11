using GCommon;
using proto;

namespace COW;

public class UIProfileMultiTeamMatchResultPlayerItemController : UIProfileNormalMatchResultItemController
{
	private new MatchStats m_MatchStats;

	protected ulong m_MatchID;

	public TeammateStats DataInfo => null;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void ShowReportButton(bool show)
	{
	}

	protected override void OnClickReportBtn()
	{
	}

	public void SetMatchData(MatchStats state, ulong id)
	{
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowReportButton(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickReportBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}
}
