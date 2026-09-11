using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudReplayCtrlView : UIBaseView
{
	public UIButton FilterBtn;

	public UIButton PauseBtn;

	public UIButton PlayBtn;

	public UIButton MinusBtn;

	public UIButton PlusBtn;

	public UILabel SpeedTxt;

	public ReplayEventBtnView EventBtnTemplate;

	public UILabel TimeTxt;

	public UISlider GameTimeSlider;

	public UISprite ProgressBG;

	public UISprite BG;

	public GameObject FilterPanel;

	public UILabel FilterTitle;

	public UIGrid FilterGrid;

	public ReportEventBtnView ReportEventBtnTemplate;

	public UIButton UploadBtn;

	public ReportOffenderEventBtnView OffenderEventBtnTemplate;

	public UIButton MarkBtn;

	public UISprite MarkBar;

	public GameObject container;

	public UISprite MarkAIBar;

	public GameObject SearchContainer;

	public UIInput SearchInput;

	public UIButton SearchHighlightButton;

	public UIButton SearchButton;

	public GameObject HighlightListOpen;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
