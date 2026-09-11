using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_MoreTeamLeaderboard_TeamItemView : UIBaseView
{
	public UILabel Rank;

	public UILabel Name;

	public UILabel Score;

	public UISprite TeamColorNoAlpha;

	public UISprite TeamColor;

	public UIButton HelpBtn;

	public UIGrid TitleGrid;

	public GameObject LabelTemp;

	public UIGrid TeammateGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
