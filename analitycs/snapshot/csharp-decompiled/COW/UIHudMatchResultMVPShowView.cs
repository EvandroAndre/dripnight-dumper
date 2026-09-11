using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultMVPShowView : UIBaseView
{
	public Animation HudMVPShowAnim;

	public UILabel GameModeTxt;

	public UILabel PlayerNameTxt;

	public UILabel TitleInfo1Txt;

	public UILabel TitleInfo2Txt;

	public UILabel TitleInfo3Txt;

	public UILabel Info1Txt;

	public UILabel Info2Txt;

	public UILabel Info3Txt;

	public UIButton ShareBtn;

	public UIButton ContinueBtn;

	public GameObject ContinueTxt;

	public GameObject DownloadRoot;

	public GameObject Download;

	public UIButton LikeBtn;

	public UILabel LikeNum;

	public GameObject VFX_Like;

	public Transform PlayerNameAndIcon;

	public Transform Info;

	public Transform InfoPosWithoutSkill;

	public Transform IsMVPSelfPlayerNamePos;

	public UISprite AfterLikebubble;

	public Transform LikeBtnContainer;

	public Animation LikeBtnContainerAnim;

	public UIWidget LikeBtnContainerWidget;

	public Transform IsMVPSelfLikeBtnPos;

	public Transform SkillPos1;

	public Transform SkillPos2;

	public Transform SkillPos3;

	public Transform SkillPos4;

	public Transform WeaponPowerPos;

	public UISprite BG2Pic;

	public UISprite BG2Border;

	public UITable Table;

	public GameObject SkillsMain;

	public UIAnchor TopAnchor;

	public UIAnchor BottomAnchor;

	public UIAnchor NameAnchor;

	public UISprite BG2Line;

	public UIGrid GroupMedals;

	public GameObject AfterLikeIcon;

	public GameObject BeforeLikeIcon;

	public GameObject BeforeLikeIconCtnZero;

	public GameObject BeforeLikeBubble;

	public Transform NameCon;

	public Transform NameOffsetPos;

	public Transform IsMVPSelfLikeBtnPosWithWeaponTitle;

	public UIGrid NameIconGrid;

	public GameObject PrivilegeIcon;

	public UILabel RatingNum;

	public GameObject RatingNumPop;

	public UILabel RatingPopLabel;

	public UISprite RatingNumPopBg;

	public UISprite WinMVPGrade;

	public UISprite FailMVPGrade;

	public GameObject RatingMvp;

	public Transform RatingMvpOffsetPos;

	public UILabel RatingNumSilver;

	public GameObject RatingNumPopBgSilver;

	public UILabel RatingNumSilverShadow;

	public UILabel RatingNumShadow;

	public UILabel RatingNumGrey;

	public UILabel RatingNumGreyShadow;

	public Transform RightAlignPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
