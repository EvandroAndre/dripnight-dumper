using System.Collections.Generic;

namespace proto;

public class ChampionshipInfo
{
	public uint championship_type;

	public TeamChampionshipInfo team_info;

	public AccountChampionshipInfo account_info;

	public List<ChampionshipWinnerInfo> winnner_infos;
}
