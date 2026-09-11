using System.Collections.Generic;

namespace proto;

public class RoomCreateRuleRes
{
	public List<RoomCreateRuleDropDesc> room_create_rule_drops;

	public List<RoomCreateRuleDesc> room_create_rules;

	public List<RoomCSZoneConfigDesc> room_cs_zone_config;
}
