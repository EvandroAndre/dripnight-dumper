using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreView : UIBaseView
{
	public UIButton DownloadOrDeletedBtn;

	public UILabel NetStateLabel;

	public UILabel HintLabel;

	public UIScrollView TabScroller;

	public UIGrid TabGrid;

	public UIScrollView SimpleScroll;

	public UIEasyList SimpleGrid;

	public UIScrollView ComplexScroll;

	public UIEasyList ComplexGrid;

	public GameObject SimpleScrollArrow;

	public GameObject ComplexScrollArrow;

	public UIButton PauseOrCancelBtn;

	public GameObject RecommendPage;

	public UIGrid RecommendGrid;

	public UIButton RecommendPageBtn;

	public UIButton ChangeToDeleteModeBtn;

	public GameObject OtherPage;

	public UILabel DownloadOrDeletedLabel;

	public UILabel PauseOrCancelLabel;

	public UIToggle DeletedSeconedCheckBtn;

	public UIEasyList SimpleDescGrid;

	public UIScrollView SimpleDescScroll;

	public UILabel TotalAccountOrSelectedRight;

	public UILabel TotalAmountOrSelectProgressRight;

	public UISprite DownloadOrDeletedBtnSprite;

	public UISprite PauseOrCancelSprite;

	public UIButton SettingBtn;

	public UILabel TotalAccountOrSelectedLeft;

	public UILabel TotalAmountOrSelectProgressLeft;

	public GameObject TotalTextRight;

	public GameObject TotalTextLeft;

	public UIButton MoreBtn;

	public GameObject MoreBtnHasRewardTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
