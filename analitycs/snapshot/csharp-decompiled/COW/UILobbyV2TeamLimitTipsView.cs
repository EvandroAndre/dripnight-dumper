using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2TeamLimitTipsView : UIBaseView
{
	public GameObject Content;

	public UIButton MaskBtn;

	public UITable Table;

	public UILabel CurTeamRankLabel;

	public UISprite LowRankIcon;

	public UISprite HighRankIcon;

	public UILabel LimitRuleTitleLabel;

	public UILabel LimitRuleDescLabel;

	public UISprite Icon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
