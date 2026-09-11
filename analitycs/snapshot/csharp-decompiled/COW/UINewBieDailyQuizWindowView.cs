using GCommon;
using UnityEngine;

namespace COW;

public class UINewBieDailyQuizWindowView : UIBaseView
{
	public GameObject QuizRoot;

	public UIButton BtnClose;

	public UISprite TitleIcon;

	public UILabel LabelTitle;

	public UILabel QuestionLabel;

	public UIButton BtnAnswer;

	public GameObject RewardRoot;

	public UIButton ChoiceItem1;

	public UILabel ChoiceLabel1;

	public UIButton ChoiceItem2;

	public UILabel ChoiceLabel2;

	public UIButton ChoiceItem3;

	public UILabel ChoiceLabel3;

	public UIButton ChoiceItem4;

	public UILabel ChoiceLabel4;

	public GameObject ResultRoot;

	public UIButton btn_ok;

	public GameObject CorrectRewardRoot;

	public UILabel InCorrectAnswer;

	public UINetworkTexture InCorrectBgCDN;

	public UINetworkTexture CorrectBgCDN;

	public UILabel InCorrectAnswer2;

	public GameObject Selected1;

	public GameObject Selected2;

	public GameObject Selected3;

	public GameObject Selected4;

	public UILabel InCorrectLabel;

	public UILabel CorrectLabel;

	public GameObject BGColor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
