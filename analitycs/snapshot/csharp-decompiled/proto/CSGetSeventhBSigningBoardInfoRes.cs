using System.Collections.Generic;

namespace proto;

public class CSGetSeventhBSigningBoardInfoRes
{
	public class SigningBoardInfo
	{
		public ulong account_id;

		public string nickname;

		public bool won_together;

		public uint match_cnt;
	}

	public List<SigningBoardInfo> signing_board_infos;

	public uint last_total;
}
