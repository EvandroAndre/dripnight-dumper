using GCommon;
using UnityEngine;

namespace COW;

public class UIClanLevelUpView : UIBaseView
{
	public UIGrid AwardGrid;

	public UIButton OKBtn;

	public GameObject ClanPrivilege;

	public UILabel NewPrivilegeLabel;

	public UILabel ClanProgressLabel;

	public GameObject UnlockAward;

	public GameObject LevelUpContainer;

	public UISprite UnlockBadgeSprite;

	public UISprite UnlockBadgeBorderLeftSprite;

	public UIButton GotoClanMallBtn;

	public UIProgressBar Progress;

	public UILabel NowClanLevelLabel;

	public UILabel PreClanLevelLabel;

	public UISprite UnlockBadgeBorderRightSprite;

	public GameObject UnlockBadgeContainer;

	public Animation Anim;

	public GameObject LockContainer;

	public UILabel NewAwardLabel;

	public UILabel VFX_top_Title;

	public GameObject ActiveRankContainer;

	public UILabel ActiveValue;

	public UIGrid RankPlayerGrid;

	public UILabel WeekDateTitle;

	public UIButton ShareBtn;

	public GameObject NoActivenessChange;

	public UIButton NoChangeGotoActiveBtn;

	public UIButton GotoActiveBtn;

	public UIButton CloseBtn;

	public UILabel BadgeLevelLabel;

	public Transform PrivilegeOnlyPos;

	public Transform RankOnlyPos;

	public UIButton AwardGotoActiveBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
