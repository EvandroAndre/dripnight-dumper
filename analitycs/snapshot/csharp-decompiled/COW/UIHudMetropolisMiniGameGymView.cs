using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisMiniGameGymView : UIBaseView
{
	public UILabel GuessReward1Txt;

	public UILabel GuessReward2Txt;

	public UILabel GuessReward3Txt;

	public UIButton GuessReward1Btn;

	public UIButton GuessReward2Btn;

	public UIButton GuessReward3Btn;

	public GameObject SimpleContent;

	public UILabel StateName;

	public GameObject PlayerIcon;

	public UILabel PlayerCountTxt;

	public GameObject SignupBG;

	public GameObject MainContent;

	public GameObject LeftWinBG;

	public UIButton LeftSelectBtn;

	public UILabel LeftPlayerName;

	public GameObject LeftPlayerIcon;

	public UISprite LeftWeaponIcon;

	public GameObject RightWinBG;

	public UIButton RightSelectBtn;

	public UILabel RightPlayerName;

	public GameObject RightPlayerIcon;

	public UISprite RightWeaponIcon;

	public UILabel CountDown;

	public GameObject WaitTimeTxt;

	public GameObject GuessingContent;

	public UILabel SimpleCountDown;

	public GameObject LeftGuessContainer;

	public UILabel LeftGuessTxt;

	public GameObject RightGuessContainer;

	public UILabel RightGuessTxt;

	public UILabel GuessValue1Txt;

	public UILabel GuessValue2Txt;

	public UILabel GuessValue3Txt;

	public GameObject WinIcon;

	public GameObject VFX_LeftChosseNotice;

	public GameObject VFX_RightChosseNotice;

	public UISlider RightHPSlider;

	public UISprite RightHPSprite;

	public TweenFill RightHPTW;

	public UISlider LeftHPSlider;

	public UISprite LeftHPSprite;

	public TweenFill LeftHPTW;

	public GameObject SelectContent;

	public UIButton CloseGuessBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
