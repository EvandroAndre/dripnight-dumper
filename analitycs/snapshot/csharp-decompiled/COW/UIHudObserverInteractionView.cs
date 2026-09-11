using UnityEngine;

namespace COW;

public class UIHudObserverInteractionView : MonoBehaviour
{
	public UIButton BtnReport;

	public UISprite ReportIcon;

	public Animator Ani_LikeContainer;

	public UIButton BtnLike;

	public UISprite LikeIcon;

	public ParticleSystem VFX_Ring;

	public UIButton BtnFriend;

	public UISprite FriendIcon;

	public UIHudObserverStickerItem EmojiObserverStickerItem;

	public UIHudObserverStickerItem GiftObserverStickerItem;

	public UIButton BtnEmoji;

	public UISprite EmojiInactive;

	public UISprite EmojiActive;

	public UISprite EmojiCDImg;

	public UISprite EmojiCDMask;

	public UITable StickerTable;

	public GameObject EmojiNode;

	public UITable AllSendTable;

	public GameObject GiftInactive;

	public GameObject SendBgNode;

	public UISprite EmojiBg;

	public Transform GiftNode;

	public UISprite LikeCDMask;

	public UISprite LikeCDImg;

	public UIButton BtnReward;

	public Transform RewardWndTransform;

	public Transform SuccessRewardTransform;

	public UILabel RewardCountLabel;

	public UISprite RewardCD;

	public GameObject RewardMask;

	public GameObject RewardClickEffect;

	public TweenScale RewardTweenScale;

	public TweenAlpha RewardTweenAlpha;
}
