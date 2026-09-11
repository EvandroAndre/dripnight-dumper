using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class SelectedItems : IMessage
{
	public uint avatar_id;

	public uint skin_color;

	public uint[] clothes;

	public List<LoadoutInfo> loadouts;

	public uint banner_id;

	public uint head_pic;

	public uint[] slots;

	public ChoosedEmotes emotes;

	public uint[] shows;

	public uint pve_primary_weapon_skin;

	public uint[] ranking_cards;

	public uint pin_id;

	public uint game_bag_show;

	public List<RandomSlotInfo> random_slots;

	public uint title;

	public QuickMsgSettings quick_msg_settings;

	public List<PveSlotInfo> pve_slots;

	public uint[] collection_actions;

	public uint[] collection_skill_skins;

	public uint load_out_v2;

	public uint[] final_shots;

	public uint super_emote;

	public uint loading_card;

	public List<RandomSkinInfo> random_skins;

	public uint avatar_frame;

	public uint finish_move;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
