using System.Collections.Generic;

namespace proto;

public class CSGetPVESettingsRes
{
	public List<PVERoundInfoDesc> round_settings;

	public List<PVELobbyInfoDesc> pve_lobby_settings;

	public List<PVEChapterInfoDesc> pve_chapter_settings;
}
