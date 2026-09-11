using System;
using GCommon;

namespace COW;

internal class UILobbyV2TeamInfoIconController : UIBaseController
{
	private const string BRTeamMapBouns = "T_40_R_MAP_BONUS_BR";

	private const string CSTeamMapBouns = "T_40_R_MAP_BONUS_CS";

	private const string TeamMapLack = "T_40_R_MAP_BONUS_TEAM_UNACTIVATED";

	private const string MemberMapLack = "T_40_R_MAP_BONUS_UNACTIVATED";

	private const string RankLimited = "T_43_TSY_RANK_LIMIT_ICON_TIPS";

	private const string TeamSocialBuf = "T_36_YY_SOCIALBUFF_DES";

	private const string MemberSocialBuf = "T_40_R_SOCIAL_BUFF";

	private const string SlayDragonBuff = "T_44_ZD_SYS_HALL_POP";

	private UILobbyV2TeamInfoIconView m_View;

	private ELobbyV2TeamInfoIconType m_Type;

	private bool m_IsTeam;

	private Action m_OnClick;

	private string m_TipsKey;

	private string m_DestIcon;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ELobbyV2TeamInfoIconType iconType, bool isTeam)
	{
	}

	private void OnButtonClick()
	{
	}

	private void OnStandardClick()
	{
	}

	private void OnTeamGameBufClick()
	{
	}

	private void OnMapLackClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
