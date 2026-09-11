using GCommon;
using UnityEngine;

namespace COW;

public class UICustomRoomRankTeamBoardView : UIBaseView
{
	public GameObject EmptyState;

	public GameObject NotAvaliable;

	public UIButton GotoSettingBtn;

	public GameObject RankContainer;

	public UITable2 RankTabel2;

	public UIPanel UICustomRoomRankTeamBoard;

	public UIPanel ScorllView;

	public UISprite NotAvaliableBG;

	public UITable2Item TeamSplit;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
