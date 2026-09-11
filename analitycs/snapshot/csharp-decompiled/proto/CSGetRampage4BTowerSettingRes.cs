using System.Collections.Generic;

namespace proto;

public class CSGetRampage4BTowerSettingRes
{
	public List<Rampage4BTowerDesc> rampage4b_tower;

	public List<Rampage4BTowerStoryDesc> rampage4b_tower_story;

	public Rampage4BTowerGoSettingShow tower_go_setting;

	public List<Rampage4BTowerProgressSettingDesc> process_setting;

	public List<Rampage4BTowerWeather> tower_weather;
}
