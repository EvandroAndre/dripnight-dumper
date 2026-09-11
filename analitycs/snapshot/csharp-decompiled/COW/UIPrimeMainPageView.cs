using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimeMainPageView : UIBaseView
{
	public GameObject UIPrimeMainPage;

	public GameObject NextLevelPrivilege;

	public UILabel LevelLabel;

	public UIProgressBar ProgressBar;

	public UIButton GoToTopUpBtn;

	public UIGrid PrivilegeGrid;

	public UIButton SwitchLeftBtn;

	public UIButton SwitchRightBtn;

	public UIButton HelpBtn;

	public UILabel PointsLabel;

	public GameObject LevelInfo;

	public GameObject Currentlevel;

	public GameObject Reached;

	public GameObject NotReach;

	public UILabel NextLevelLabel;

	public UILabel TopUpDescLabel;

	public GameObject NextLevelItem;

	public UISprite ProgressFg;

	public UISprite GotoTopUpLine;

	public UILabel GotoTopUpLabel;

	public UISprite GotoTopUpArrow;

	public GameObject LevelDowning;

	public UILabel LevelDowningLabel;

	public UISprite ItemIcon;

	public UISprite NextLevelPrivilegeIcon;

	public PrimeSmallBadgeVfxUtil PrimeSmallBadgeVfxUtil;

	public UISprite QualityBG;

	public UISprite SpriteQualityPlus;

	public UISprite SpriteOrangeQualityPlus;

	public Transform LeftBadge;

	public UIButton NextLevelBtn;

	public GameObject UIFX_VIPPrime_Success;

	public UILabel AddLabel;

	public TweenPosition AddTweenPosition;

	public TweenAlpha AddTweenAlpha;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
