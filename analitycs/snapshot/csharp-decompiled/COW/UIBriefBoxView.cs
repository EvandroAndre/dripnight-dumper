using GCommon;
using UnityEngine;

namespace COW;

public class UIBriefBoxView : UIBaseView
{
	public UIPanel UIBriefBox;

	public UIWidget Container;

	public Transform ProfileContainer;

	public UIGrid ItemGrid;

	public UIWidget ItemGridWidget;

	public UISprite BGBorderVip;

	public Transform ProfilePivot;

	public UIScrollView ScrollView;

	public Transform Rank;

	public GameObject SeaSonBrContainer;

	public GameObject SeaSonCsContainer;

	public GameObject SeaSonCsCoontainer;

	public GameObject PersonHeroicMarkCSRoot;

	public UIButton CSNotObtainedIconBth;

	public UILabel UILabelHeroicMarkCSIconBtn;

	public UIButton UIButtonHeroicMarkCSIconBtn;

	public Transform HeroicCSEffect;

	public UILabel PersonSeaSonRankNameCS;

	public GameObject SeaSonBrCootainer;

	public GameObject PersonHeroicMarkBRRoot;

	public UIButton BRNotObtainedIconBth;

	public UILabel UILabelHeroicMarkBRIconBtn;

	public UIButton UIButtonHeroicMarkBRIconBtn;

	public Transform HeroicBREffect;

	public UILabel PersonSeaSonRankPoint;

	public UILabel PersonSeaSonHistoryRankPoint;

	public Transform Center;

	public UILabel LikeLabel;

	public UIWidget Mask;

	public GameObject LikedIcon;

	public UIButton NoLikeIcon;

	public UILabel NewLikeLabel;

	public GameObject LikeFX;

	public Transform CSRankIconContainer;

	public Transform BRRankIconContainer;

	public UIButton ClanInfoBtn;

	public UIWidget ClanInfoBtnWidget;

	public GameObject SeasonOccupationContainer;

	public UILabel OccupationLevel;

	public UISprite OccupationSprite;

	public UILabel OccupationTitle;

	public Transform HideRolePos;

	public Transform ShowRolePos;

	public Transform SocialHighLightPos;

	public Transform LeaderboardTitlePos;

	public GameObject HonorContainer;

	public GameObject SocialItem;

	public GameObject LeaderboardTitleItem;

	public GameObject SwitchBtnContainer;

	public UISprite OccupationRank;

	public UIGrid SideButtonGrid;

	public UIButton OccupationGoposBtn;

	public UIWidget ScrollableWidget;

	public GameObject CustomProfileNode;

	public UISprite HeroicMarkBgBRIcon;

	public UISprite HeroicMarkBgCSIcon;

	public UISprite HeroicMarkSIcon;

	public GameObject UIFX_ScaleAll;

	public GameObject Line1;

	public GameObject Line2;

	public VFXCreateHelper InVFX;

	public VFXCreateHelper UpLoopVFX;

	public VFXCreateHelper DownLoopVFX;

	public UISprite BGBorderNormal;

	public GameObject ProfileBtnBg;

	public GameObject ProfilePrimeBtnBg;

	public Transform PrimeIcon;

	public UITable BtnTable;

	public GameObject RTop;

	public UIButton CSPeakTournamentRankContainer;

	public UILabel CSPeakTournamentRankName;

	public UIAnchorPositionCtrl AnchorPosition;

	public Transform CSPeakIconContainer;

	public GameObject SeaSonInfoToogleGroup;

	public UILabel PersonSeaSonName;

	public UISprite BGBorderBanned;

	public UILabel BannedReason;

	public GameObject MinWidget;

	public GameObject MinWidget2;

	public UILabel BannedTime;

	public Transform SparkpetPos;

	public GameObject SparkpetContainer;

	public Transform BannedDeleteFriend;

	public UIButton SimulatorIcon;

	public GameObject GotoSocialLobby;

	public UIButton GotoSocialLobbyBtn;

	public UIWidget GotoSocialLobbyBtnWidget;

	public UIButton PhotoWallBtn;

	public Transform DownloadContainer;

	public GameObject PhotoWallContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
