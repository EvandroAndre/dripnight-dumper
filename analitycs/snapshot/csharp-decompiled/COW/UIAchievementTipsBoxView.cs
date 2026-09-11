using GCommon;
using UnityEngine;

namespace COW;

public class UIAchievementTipsBoxView : UIBaseView
{
	public UINetworkTexture AchievementBadgeImage;

	public UIButton GoPosArrow;

	public UILabel AchievementNameLabel;

	public UILabel AchievementContentLabel;

	public UIButton ClickMask;

	public GameObject UIAchievementTipsBox;

	public GameObject Content;

	public Animation Animation;

	public UILabel NextRankLabel;

	public GameObject RankUpNode;

	public Animation RankUpAnimation;

	public UILabel RankDescLabel;

	public Transform ProfileNode;

	public UILabel RankUpNameLabel;

	public UILabel CurRankLabel;

	public UILabel RankExceedLabel;

	public Transform GlowEffect;

	public UINetworkTexture AchievementBigEventCDN;

	public GameObject CompletedSprite;

	public GameObject AwardSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
