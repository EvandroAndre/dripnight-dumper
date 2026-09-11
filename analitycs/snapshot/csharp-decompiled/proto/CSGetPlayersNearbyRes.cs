using System.Collections.Generic;

namespace proto;

public class CSGetPlayersNearbyRes
{
	public class AccountWithDist
	{
		public AccountInfoBasic basic_info;

		public double distance;

		public ELbs.HideDistance hide_distance;
	}

	public List<AccountWithDist> accounts;
}
