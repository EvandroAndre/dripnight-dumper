using ProtoBuf;

namespace proto;

public class DrawShopLimitedPoolChangeSkinDesc : IMessage
{
	public uint draw_shop_id;

	public string title_ui_fx;

	public string lobby_entrance_ui_fx;

	public string big_reward_ui_fx;

	public string big_reward_drop_ui_fx;

	public string perm_reward_ui_fx;

	public string language;

	public string lobby_entrance_cdn;

	public string lobby_entrance_bubble_cdn;

	public string tab_cdn;

	public string bg_cdn;

	public string goods_bg_cdn;

	public string title_cdn;

	public string rare_gray_bg_cdn;

	public string rare_blue_bg_cdn;

	public string rare_green_bg_cdn;

	public string rare_purple_bg_cdn;

	public string rare_purple_plus_bg_cdn;

	public string rare_orange_bg_cdn;

	public string rare_orange_plus_bg_cdn;

	public string rare_red_plus_bg_cdn;

	public string big_reward_purple_bg_cdn;

	public string big_reward_purple_plus_bg_cdn;

	public string big_reward_orange_bg_cdn;

	public string big_reward_orange_plus_bg_cdn;

	public string big_reward_red_bg_cdn;

	public string pool_bg_cdn;

	public string notice_cdn;

	public string buy_btn_cdn;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
