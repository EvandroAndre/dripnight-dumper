using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDTeamParachuteActionView : UIBaseView
{
	public UIButton ActionBtn;

	public UILabel ActionName;

	public UISprite ActionIcon;

	public GameObject leaderPanel;

	public UIButton bgBtn;

	public GameObject teammate1;

	public UILabel teamid1Selected;

	public UILabel teamid1;

	public UIToggleButton btn1;

	public UISprite btn1Sprite;

	public GameObject teammate2;

	public UILabel teamid2Selected;

	public UILabel teamid2;

	public UIToggleButton btn2;

	public UISprite btn2Sprite;

	public GameObject teammate3;

	public UILabel teamid3Selected;

	public UILabel teamid3;

	public UIToggleButton btn3;

	public UISprite btn3Sprite;

	public UILabel teammate1Name;

	public UILabel teammate2Name;

	public UILabel teammate3Name;

	public Transform leaderTips;

	public UISprite team1Icon;

	public UISprite team2Icon;

	public UISprite team3Icon;

	public UIWidget MaskContainer;

	public Transform followTips;

	public UILabel followeLeaderId;

	public UISprite followLeaderIcon;

	public GameObject leaderRequestPanel;

	public Animation RequestListAnim;

	public UIButton AcceptBtn;

	public UIButton RejectBtn;

	public UISprite RequestTeamIcon;

	public UILabel RequestTeamIdx;

	public UILabel RejectTimeLabel;

	public GameObject CDMask;

	public UISprite CDProgress;

	public UIButton ReqLeaderBtn;

	public GameObject MainAction;

	public UILabel requestText;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
