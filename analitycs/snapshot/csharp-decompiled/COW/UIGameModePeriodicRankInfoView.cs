using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModePeriodicRankInfoView : UIBaseView
{
	public UIButton BtnModelPick;

	public UILabel LabelPeriodicModeName;

	public GameObject openTime;

	public UILabel openPeriod;

	public GameObject LevelContainer;

	public UILabel seasonName;

	public UISprite SpriteRankIcon;

	public UIButton BtnRankIcon;

	public GameObject GoMaxRank;

	public GameObject StarIcon;

	public UILabel MaxRankTxt;

	public Transform TransformStar;

	public UIGrid GridStar;

	public GameObject star1;

	public GameObject star2;

	public GameObject star3;

	public GameObject star4;

	public GameObject star5;

	public GameObject blackstar5;

	public GameObject blackstar4;

	public GameObject blackstar3;

	public GameObject blackstar2;

	public GameObject blackstar1;

	public GameObject NoticeBg;

	public UILabel LabelNotice;

	public GameObject GoDownload;

	public Transform TrRootDownload;

	public GameObject GoLevelLimit;

	public UILabel LabelLevelLimit;

	public UILabel MapMode;

	public UIButton MapChangeButton;

	public GameObject UIGameModePeriodicRankInfo;

	public Transform OpenTimeAnchorWithoutSeason;

	public Transform OpenTimeAnchorWithSeason;

	public GameObject NoticeDuoVersion;

	public GameObject VersionUpdateOK;

	public GameObject VersionUpdateNotOK;

	public GameObject MapChange;

	public GameObject BanMatchContainer;

	public UILabel BanMatchLabel;

	public Transform BanMatchTime;

	public UIButton BanMatchBtn;

	public UISprite SeasonThemeIcon;

	public UINetworkTexture SeasonThemeEntranceBgTexture;

	public GameObject DefaultEntranceBgGroup;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
