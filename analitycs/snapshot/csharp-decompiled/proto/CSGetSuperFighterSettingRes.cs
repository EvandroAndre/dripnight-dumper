using System.Collections.Generic;

namespace proto;

public class CSGetSuperFighterSettingRes
{
	public SuperFighterSettingDesc setting_desc;

	public List<SuperFighterBoxingDesc> boxing_descs;

	public List<SuperFighterEnemyDesc> enemy_descs;
}
