using GCommon;
using UnityEngine;

namespace COW;

public class UIScoreDetailTipsView : UIBaseView
{
	public UIButton MaskBtn;

	public GameObject Content;

	public UILabel TitleLabel;

	public UILabel AddScore;

	public UILabel NoDropLabel;

	public UISprite NoDropIcon;

	public UIScoreDetailItemUtil ScoreDetailItemTemplate;

	public UIWidget ScoreDetailItemWidget;

	public GameObject NoDrop;

	public UITable ContentTable;

	public UIGrid Grid;

	public UIWidget StreakContainer;

	public UILabel StreakDesc;

	public UILabel StreakNum;

	public UILabel StreakNumRed;

	public UILabel ExpNum;

	public GameObject StreakIcon;

	public UISprite BG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
