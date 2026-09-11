using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetBackpackRes : IMessage
{
	public AccountWallet wallet;

	public SelectedItems selected_items;

	public List<Item> items;

	public MaxLobbyDisplayInfo max_lobby_display;

	public List<PermanentValueItem> expired_permanent_value_items;

	public List<WeaponSkinStat> weapon_skin_stat;

	public AccountCoinsOutGame coins_out_game;

	public uint[] collection_guides;

	public List<WeaponSkinCustom> weapon_skin_customs;

	public List<ItemTagInfo> tag_items;

	public uint[] permanent_weapon_skin_ids;

	public List<LoadoutInfo> all_loadouts;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
