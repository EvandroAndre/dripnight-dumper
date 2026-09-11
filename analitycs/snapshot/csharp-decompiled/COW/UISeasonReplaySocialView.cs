using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplaySocialView : UIBaseView
{
	public GameObject LikedIcon;

	public GameObject NotLikeIcon;

	public GameObject LikeVFX;

	public UIButton LikeBtn;

	public UILabel ExclusiveValue;

	public UILabel ExclusiveName;

	public GameObject Friend1;

	public GameObject Friend2;

	public GameObject LoneWolfContainer;

	public Animation LoneWolfContainerAnim;

	public GameObject NormalContainer;

	public GameObject Friend3;

	public UILabel Title;

	public GameObject NotMostMatchFriendContainer;

	public Animation NormalContainerAnim;

	public Animation LikeContainer;

	public GameObject UIFX_SeasonLabelLoneWolf;

	public GameObject UIFX_SeasonLabelNormal;

	public UICurveScrollViewUtil CircleCenter;

	public UIButton ScorllBtn;

	public Transform ItemContainer;

	public GameObject SelfContainer;

	public UIEffectSprite SelfHeadIcon;

	public UILabel SelfClanName;

	public UISprite SelfProfileBG;

	public UILabel SelfNickName;

	public Transform DragGuide;

	public UISprite CircleArrow;

	public GameObject NormalDataDesc;

	public GameObject HighestRankDataDesc;

	public UILabel FriendLabel;

	public GameObject RankIconContainer;

	public GameObject Positive;

	public GameObject Negative;

	public UISprite CircleArrowtop;

	public UISprite TitleLine;

	public GameObject UIFX_TitleLabel;

	public GameObject NegaticeFriendAll;

	public GameObject PositiveFriendAll;

	public UILabel DescLabel;

	public UISprite line03;

	public UISprite line04;

	public UISprite line01;

	public UISprite line02;

	public UISprite bg1;

	public UISprite bg2;

	public UISprite bg3;

	public UISprite bg4;

	public UIWidget RankIconContainerGM;

	public GameObject NormalV2Container;

	public UIGrid SocialTagsGrid;

	public UIButton SummaryBtn;

	public UILabel SummaryBtnLabel;

	public UIButton TakePhotoBtn;

	public GameObject DownloadingPose;

	public Transform PoseDownloadingContainer;

	public GameObject TakePhotoBtnBubble;

	public Transform SocialTags;

	public Animation NormalV2ContainerAnim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
