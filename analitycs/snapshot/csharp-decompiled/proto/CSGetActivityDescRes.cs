using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetActivityDescRes : IMessage
{
	public List<ClientActivityDesc> activity_descs;

	public List<ActivityFestivalDesc> activity_festivals;

	public List<ClientActivityEntranceSwitchDesc> entrance_list;

	public List<ClientActivityBingoInfoDesc> bingo_info;

	public List<ActivityBingoRewardsDesc> bingo_rewards_info;

	public List<EventIntegretPageDesc> event_integret_pages;

	public List<LobbyGameEnterStyleDesc> lobby_game_enter_styles;

	public List<ActivityInteractionDesc> activity_interaction_descs;

	public List<ActivityTipsDesc> activity_tips_desc;

	public List<ActivityTemplateDesc> activity_templates;

	public List<ActivityFestivalSortRuleDesc> activity_festival_sort_rules;

	public ActivityESportsDesc activity_esports_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
