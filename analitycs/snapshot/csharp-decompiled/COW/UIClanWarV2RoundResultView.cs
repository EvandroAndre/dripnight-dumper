using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarV2RoundResultView : UIBaseView
{
	public UIButton ConfirmBtn;

	public UIButton EquipmentBtn;

	public GameObject UpArrow;

	public GameObject DownArrow;

	public UILabel RankChangeLabel;

	public UIButton ShareBtn;

	public UILabel RankScoreLabel;

	public UISprite LeaderBoardTitleIcon;

	public UILabel RegionName;

	public UIButton CloseBtn;

	public GameObject RankingChange;

	public UIAnchor ShareBtnAnchor;

	public UITable BtnTable;

	public GameObject BottomBtnContainer;

	public UILabel NotInBoradLabel;

	public UILabel TitleLabel;

	public Transform CenterContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
