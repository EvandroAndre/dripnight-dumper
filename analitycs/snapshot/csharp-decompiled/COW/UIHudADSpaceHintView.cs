using GCommon;
using UnityEngine;

namespace COW;

public class UIHudADSpaceHintView : UIBaseView
{
	public GameObject Enter1v1Warning;

	public GameObject Enter1v1Hint;

	public UISprite Avatar;

	public UILabel HintLabel;

	public GameObject End1v1TimeOut;

	public GameObject Start1v1Info;

	public UISprite Start1v1InfoIcon;

	public UILabel Start1v1InfoTitle;

	public UILabel Start1v1InfoInfo;

	public GameObject Win1V1Kill;

	public GameObject Win1v1;

	public UISprite WinAvatar;

	public UILabel Win1v1Label;

	public GameObject SelfWinBg;

	public GameObject RivalWinBg;

	public GameObject Win1v1BonusScore;

	public UISprite TeamIcon;

	public GameObject SelfWinBgTeam;

	public GameObject RivalWinBgTeam;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
