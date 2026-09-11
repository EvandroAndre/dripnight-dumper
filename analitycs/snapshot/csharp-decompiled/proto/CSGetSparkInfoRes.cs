namespace proto;

public class CSGetSparkInfoRes
{
	public ulong account_id;

	public bool claimed;

	public bool show_spark_in_lobby;

	public bool show_collab_spark;

	public SparkInfo user_spark_info;

	public SparkInfo collab_spark_info;

	public uint[] claimed_level_awards;

	public bool level_upgraded;

	public bool is_daily_first_login;

	public EFriend.SparkStateTransitionType spark_state_transition;

	public uint[] unlocked_color_ids;

	public SparkGachaPoolInfo spark_gacha_pool_info;
}
