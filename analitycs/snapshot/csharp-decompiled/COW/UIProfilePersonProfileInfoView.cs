using GCommon;
using UnityEngine;

namespace COW;

public class UIProfilePersonProfileInfoView : UIBaseView
{
	public GameObject PersonalCard;

	public UISprite PersonProfileInfobg;

	public UISprite PersonfakeBg;

	public UISprite PersonProfileInfobgLow;

	public UISprite PersonfakeLow;

	public GameObject PersonFavorSprite;

	public UIEffectSprite PersonHeadSprite;

	public GameObject PersonFakeSprite;

	public UIButton epbtn;

	public GameObject EPTipsContainer;

	public UIButton EPHelperMaskBtn;

	public UIButton likebtn;

	public GameObject LikeTipsContainer;

	public UIButton LikeHelperMaskBtn;

	public GameObject PersoninfoContainer;

	public UISprite Personvip;

	public UILabel PersonvipLv;

	public UILabel UILabelPersonlevel;

	public UICustomHoverButton UICustomHoverButtonPersonlevel;

	public UILabel PersonclanName;

	public UILabel PersonLagr;

	public UISprite PlayerSex;

	public UISprite LanguageSprite;

	public Transform PersonnicknameTr;

	public UILabel Personnickname;

	public UIButton BtnChangeName;

	public UILabel IDLabel;

	public UIButton copybtn;

	public UILabel likeslabel;

	public UISprite UISpritePinIcon;

	public UIButton UIButtonGuildbtn;

	public UICustomHoverButton UICustomHoverButtonOnLineTime;

	public UISprite UISpriteOnLineTime;

	public UICustomHoverButton UICustomHoverButtonActiveTime;

	public UISprite UISpriteActiveTime;

	public UICustomHoverButton UICustomHoverButtonModePrefer;

	public UISprite UISpriteModePrefer;

	public GameObject SeaSonCsCoontainer;

	public UILabel CSSEASON_S;

	public UILabel CSeason_L;

	public Transform PersonHeroicMarkCSRoot;

	public UILabel HeroicMarkLabel;

	public Transform TransformCSNotObtainedIcon;

	public UIButton UIButtonCSNotObtainedIcon;

	public UILabel UILabelHeroicMarkCSIcon;

	public UIButton UIButtonHeroicMarkCSIcon;

	public Transform HeroicCSEffect;

	public UILabel PersonSeaSonDesNowCS;

	public UILabel PersonSeaSonRankNameCS;

	public UICustomHoverButton UICustomHoverButtonPersonRankIconCS;

	public GameObject SeaSonBrCootainer;

	public UILabel BRSEASON_S;

	public UILabel BRSeason_L;

	public Transform PersonBRHeroicMarkRoot;

	public Transform TransformBRNotObtainedIcon;

	public UIButton UIButtonBRNotObtainedIcon;

	public UILabel UILabelHeroicMarkBRIcon;

	public UIButton UIButtonHeroicMarkBRIcon;

	public Transform HeroicBREffect;

	public UILabel PersonSeaSonDesNow;

	public UILabel PersonSeaSonRankName;

	public UICustomHoverButton UICustomHoverButtonPersonRankIcon;

	public UILabel PersonSeaSonHistoryRankPoint;

	public UIButton PersonBtnSetting;

	public UISprite SpriteRedDotSetting;

	public UIButton Personheadbtn;

	public Animation main;

	public UIWidget HeadpicGuideWidget;

	public UILabel NewLikesLabel;

	public TweenPosition NewLikesLableTweenPosition;

	public UIButton NoLikeIcon;

	public GameObject LikedIcon;

	public UISprite LikedIconSprite;

	public UIWidget Likesicon;

	public GameObject LikeContainer;

	public UIWidget LikeGuideWidget;

	public UIButton LikeGuideButton;

	public BoxCollider LikeGuideButtonBoxCollider;

	public UIWidget LikeGuideButtonWidget;

	public GameObject LikeFX;

	public Transform BRRankIconContainer;

	public Transform CSRankIconContainer;

	public GameObject PersonalClanInfo;

	public UIButton ClanPopupBtn;

	public UILabel SwitchLabel;

	public UISprite ClanIcon;

	public UISprite ClanFrame;

	public UINetworkTexture ClanCDN;

	public GameObject PersonShowNodeRight;

	public GameObject PersonProfileInfo;

	public BoxCollider RightCollider;

	public UIButton LevelGiftButton;

	public GameObject LevelGift;

	public GameObject LevelGiftBubblePviot;

	public GameObject OccupationCootainer;

	public UISprite OccupationRoleIcon;

	public UILabel OccupationLevel;

	public UISprite OccupationBG;

	public UILabel OccupationTitlle;

	public Transform OccupationExistPos;

	public Transform OccupationNotExistPos;

	public GameObject DisableMask;

	public UILabel SeaSonBRCSLabel;

	public UILabel SeaSonSeasonLabel;

	public UIButton SeasonSwitchBtn;

	public UISprite CustomProfileButtomLine;

	public UISprite CustomProfileUpLine;

	public UISprite HeroicMarkBgCSIcon;

	public UISprite HeroicMarkBgBRIcon;

	public UISprite HeroicMarkSIcon;

	public GameObject UIFX_Scale_Occupation;

	public GameObject NetworkBlock;

	public GameObject Loading;

	public GameObject NormalBg;

	public GameObject VipBg;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	public UIButton CSPeakTournamentRankContainer;

	public UILabel CSPeakTournamentRankName;

	public UIAnchorPositionCtrl AnchorPosition;

	public Transform CSPeakIconContainer;

	public UILabel PersonSeaSonName;

	public UILabel CSPeakOccupationLevel;

	public UISprite CSPeakOccupationBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
