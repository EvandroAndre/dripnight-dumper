namespace proto;

public class CSPlayerBooyahChessInfo
{
	public ulong account_id;

	public EMiniGame.GameStatus game_status;

	public uint player_index;

	public uint current_step;

	public uint current_weapon;

	public uint booyah_times;

	public Chessboard chessboard;

	public Circle current_circle;

	public uint current_reward_cnt;

	public uint total_reward_cnt;

	public bool is_booyah;

	public bool is_finish;

	public int booyah_index;

	public uint play_times;
}
