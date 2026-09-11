using ProtoBuf;

namespace proto;

public class DrawShopWheelChangeSkinDesc : IMessage
{
	public uint draw_shop_id;

	public string language;

	public string cdn_lobby_rev_icon;

	public string cdn_lobby_rev_bubble;

	public string cdn_tab;

	public string cdn_title;

	public string cdn_background;

	public string cdn_model_drawing;

	public string cdn_left_button;

	public string cdn_right_button;

	public string cdn_left_discount;

	public string cdn_right_discount;

	public string cdn_table_up;

	public string cdn_table_down;

	public string cdn_exchange_bg;

	public string cdn_big_prize;

	public string cdn_sub_title;

	public string title_ui_fx;

	public string left_button_ui_fx;

	public string right_button_ui_fx;

	public string left_discount_pos;

	public string right_discount_pos;

	public string left_discount_ui_fx;

	public string right_discount_ui_fx;

	public string background_ui_fx;

	public string lobby_entrance_ui_fx;

	public string card_pool_ui_fx;

	public string cdn_time;

	public uint custom_type;

	public string single_draw_flip_card_ui_fx;

	public string multi_draw_ui_fx;

	public string top_background_ui_fx;

	public string cdn_card_face;

	public string cdn_card_item_selected_frame;

	public string cdn_exchange_item_own_state;

	public string card_pool_big_prize_primary_ui_fx;

	public string card_pool_big_prize_secondary_ui_fx;

	public string card_pool_completion_ui_fx;

	public string card_pool_sweep_light_ui_fx;

	public string card_pool_selected_ui_fx;

	public string exchange_button_ui_fx;

	public string top_right_panel_ui_fx;

	public string cdn_card_pool_top_background_1;

	public string cdn_card_pool_top_background_2;

	public string cdn_wheel_exchange_button;

	public string cdn_tab_background;

	public string card_pool_big_prize_ui_fx;

	public string entrance_ui_fx;

	public string cdn_lobby_rev_icon2;

	public string cdn_lobby_rev_icon3;

	public string lobby_entrance_anim_clip_name;

	public string chest_container_ui_fx;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
