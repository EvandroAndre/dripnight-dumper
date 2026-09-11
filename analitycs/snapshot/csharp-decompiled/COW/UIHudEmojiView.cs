using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEmojiView : UIBaseView
{
	public UISprite NewEmoji;

	public UISprite FadeEmoji;

	public GameObject EmojiEffect;

	public GameObject Teammate;

	public UILabel TeammateIndex;

	public GameObject FadeTeammate;

	public UILabel FadeTeammateIndex;

	public UISprite FadeTeammateBG;

	public GameObject Friend;

	public UILabel FriendName;

	public UISprite NewEmojiShadow;

	public GameObject Giftemoji;

	public UILabel SendGiftFriendLabel;

	public GameObject GiftEffect;

	public GameObject FadeGift;

	public Animation GiftAnim;

	public UILabel FadeSendGiftFriendLabel;

	public UISprite bg;

	public UISprite line;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
