using System.Collections.Generic;

namespace COW;

public static class UIRuleDataManager
{
	public static readonly string RULE_CHEST_RULE_TILTE;

	public static readonly string RULE_CHEST_RULE_INFO2;

	public static readonly string RULE_CHEST_WHEEL_HELP_TAB;

	public static readonly string RULE_CHEST_WHEEL_HELP_DESC;

	public static readonly string RULE_CHEST_LEGEND_HELP_TAB;

	public static readonly string RULE_CHEST_LEGEND_HELP_DESC;

	public static readonly string RULE_CHEST_FADED_HELP_TAB;

	public static readonly string RULE_CHEST_FADED_HELP_DESC;

	public static readonly string RULE_CHEST_HACKER_STORE_HELP_TAB;

	public static readonly string RULE_CHEST_HACKER_STORE_HELP_DESC;

	public static readonly string RULE_CHEST_NEW_UNLIMITED_TAB;

	public static readonly string RULE_CHEST_NEW_UNLIMITED_DESC;

	public static readonly string RULE_CHEST_DOUBLEWHEEL_TAB;

	public static readonly string RULE_CHEST_DOUBLEWHEEL_DESC;

	public static readonly string RULE_CS_CLAN_RULE;

	public static readonly string RULE_CLAN_TITLE_LEVEL;

	public static readonly string RULE_CLAN_TITLE_ACTIVE;

	public static readonly string RULE_CLAN_TITLE_WAR;

	public static readonly string RULE_CLAN_TITLE_NEWS;

	public static readonly string RULE_CLAN_TITLE_OTHER;

	public static readonly string RULE_CLAN_TITLE_LEVEL_DESC;

	public static readonly string RULE_CLAN_TITLE_ACTIVE_DESC;

	public static readonly string RULE_CLAN_TITLE_WAR_DESC;

	public static readonly string RULE_CLAN_TITLE_NEWS_DESC;

	public static readonly string RULE_CLAN_TITLE_OTHER_DESC;

	public static readonly string RULE_MYSTERYMALL;

	public static readonly string RULE_WEAPON_RACK;

	public static readonly string RULE_CREDIT_RULE;

	public static readonly string RULE_LADDER_CSPEAK;

	public static readonly string RULE_LADDER_RANK;

	public static readonly string RULE_LADDER_WEAPON;

	public static readonly string RULE_LADDER_WISHLIST;

	public static readonly string RULE_LADDER_OTHER;

	public static readonly string RULE_CSPeak_RULE;

	public static readonly string RULE_CSPeak_NAME;

	public static readonly string RULE_CSPeak_TIPS;

	public static readonly string RULE_CSPeak_ENERGY;

	public static readonly string RULE_CSPeak_ENERGY_TIPS;

	public static readonly string RULE_CSPeak_FAMEHALL;

	public static readonly string RULE_CSPeak_FAMEHALL_TIPS;

	public static readonly string RULE_CSPeak_SQUAD;

	private static Dictionary<int, List<RuleMapping>> m_RuleDic;

	public static List<RuleMapping> RulesOfType(RuleType ruleType, object extralData)
	{
		return null;
	}
}
