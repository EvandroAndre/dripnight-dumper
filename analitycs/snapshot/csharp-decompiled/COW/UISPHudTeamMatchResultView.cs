using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudTeamMatchResultView : UIBaseView
{
	public GameObject BG;

	public UITexture LocalBG;

	public UILabel MatchModeTxt;

	public UILabel MatchMapTxt;

	public UIEasyList ResultListGrid;

	public UILabel Result;

	public UIButton NextBtn;

	public UIButton DetailsBtn;

	public GameObject Top1;

	public UISprite Top1FakeIcon;

	public UISprite Top1TeamIcon;

	public UILabel Top1ScoreLabel;

	public UILabel Top1KillCountLabel;

	public UILabel Top1TeamName;

	public GameObject Top2;

	public UISprite Top2TeamIcon;

	public UISprite Top2FakeIcon;

	public UILabel Top2ScoreLabel;

	public UILabel Top2KillCountLabel;

	public UILabel Top2TeamName;

	public GameObject Top3;

	public UISprite Top3FakeIcon;

	public UISprite Top3TeamIcon;

	public UILabel Top3ScoreLabel;

	public UILabel Top3KillCountLabel;

	public UILabel Top3TeamName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
