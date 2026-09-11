using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudCSMatchInfoView : UIBaseView
{
	public TweenPosition TWPosition;

	public TweenAlpha TWAlpha;

	public GameObject EconomyInfo;

	public UILabel EconomyBlue;

	public UILabel EconomyRed;

	public UIProgressBar EconomyBar;

	public UILabel TeamBlueName;

	public UILabel myWinNum;

	public UILabel oppoWinNum;

	public GameObject RoundInfo;

	public UILabel remainTime;

	public UILabel curRound;

	public GameObject BombCountdownInfo;

	public UISprite FillBg;

	public UILabel TeamRedName;

	public UISprite TeamBlueIcon;

	public UISprite TeamRedIcon;

	public GameObject TeamBlueDefaultIcon;

	public UISprite Team1Icon;

	public GameObject TeamRedDefaultIcon;

	public UISprite Team2Icon;

	public GameObject BombInfo;

	public UISprite BlueFactionIcon;

	public UISprite RedFactionIcon;

	public UIProgressBar BlueRemoveProgressBar;

	public UILabel BlueRemoveHint;

	public UIProgressBar RedRemoveProgressBar;

	public UILabel RedRemoveHint;

	public GameObject techRoot;

	public GameObject Glow_Left;

	public GameObject Glow_Right;

	public Transform myTeamTechTrans;

	public Transform oppoTeamTechTran;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
