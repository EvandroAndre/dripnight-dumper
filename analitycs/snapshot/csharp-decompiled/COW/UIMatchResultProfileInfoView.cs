using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchResultProfileInfoView : UIBaseView
{
	public Animator UIMatchResultProfileInfo;

	public GameObject SelfBG;

	public GameObject NormalBG;

	public UILabel PlayerNameTxt;

	public UILabel KillTitle;

	public UILabel KillNumTxt;

	public UILabel DamageTitle;

	public UILabel DamageNumTxt;

	public GameObject MVPFlag;

	public GameObject WinMVPGrade;

	public GameObject FailMVPGrade;

	public Transform WeaponPowerContainer;

	public UILabel PlayerSelfNameTxt;

	public Transform TitleContainer;

	public GameObject PrivilegeIcon;

	public UILabel RatingNum;

	public GameObject RatingContainer;

	public UISprite RatingBg;

	public GameObject UIFX_Silvery;

	public GameObject UIFX_Golden;

	public UILabel RatingSelNumForGrey;

	public GameObject PlayerNameTxtContainer;

	public UILabel RatingNum_Silvery;

	public UISprite RatingIcon;

	public UISprite BG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
