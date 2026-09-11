using GCommon;

namespace COW;

public class UIChatMessageItemNewGroupInviteController : UIBaseController
{
	private UIChatMessageItemNewGroupInviteView m_View;

	private const string BRRANK_BG = "UI_Chat_Rank_bg";

	private const string CSRANK_BG = "UI_Chat_Rank_CS_bg";

	private const string CLANWAR_BG = "UI_Chat_ClanWar_bg";

	private const string NORMAL_BG = "UI_Chat_Normal_bg";

	private const string HCRANK_BG = "UI_Chat_Rank_HC_bg";

	private const string CSPEAK_BG = "UI_Chat_CSPeakTournament_bg";

	private UIBRRankIconController m_MaxBRRankIconController;

	private UIBRRankIconController m_MinBRRankIconController;

	private UICSPeakTournamentRankIconController m_MinCSPeakRankIconController;

	private UICSPeakTournamentRankIconController m_MaxCSPeakRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(MessageInfo info, bool hasLuckyBuffInRecruit, bool hasMapBonusBuff = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
