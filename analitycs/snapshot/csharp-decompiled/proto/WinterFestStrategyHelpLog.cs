namespace proto;

public class WinterFestStrategyHelpLog
{
	public enum HelpType
	{
		None,
		Collect,
		Order
	}

	public HelpType type;

	public ulong helper;

	public ulong helpee;

	public MiniGameItem helper_reward_minigame;

	public MiniGameItem helpee_reward_minigame;

	public Item helpee_reward;

	public uint devote_points;
}
