using System.Collections.Generic;

namespace tcp;

public class GooglePlayAchievementUpdateNtf
{
	public ulong account_id;

	public string player_id;

	public List<GooglePlayAchievementUpdate> updates;
}
