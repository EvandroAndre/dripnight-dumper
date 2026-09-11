using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditItemGenView : UIBaseView
{
	public TweenPosition TweenPos;

	public UILabel WordCountLabel;

	public UIInput SearchUIInput;

	public UIButton SearchBtn;

	public GameObject NormalBg;

	public GameObject HighlightBg;

	public UITable HistoryTable;

	public UIButton DelBtn;

	public UITable GuessTable;

	public UIButton RefreshBtn;

	public GameObject History;

	public GameObject Guess;

	public UITable SuggestionTable;

	public GameObject SearchStateContainer;

	public GameObject SelectStateContainer;

	public UIButton CloseBtn;

	public UITable SearchResTable;

	public UILabel PageLabel;

	public GameObject SearchRes;

	public GameObject SearchFailed;

	public GameObject Searching;

	public UIButton PreviousBtn;

	public UIButton NextBtn;

	public GameObject PreviousBtnHide;

	public GameObject PreviousBtnShow;

	public GameObject NextBtnHide;

	public GameObject NextBtnShow;

	public UILabel SearchFailedLabel;

	public UIWidget DragGuide1;

	public UIButton SearchStateHelpBtn;

	public GameObject InputPlaceHolder;

	public UIWidget DragGuide2;

	public Animation Ani;

	public UIButton BackBtn;

	public UIButton SearchResHelpBtn;

	public GameObject DragPrompts;

	public GameObject SearchResHeader;

	public GameObject SearchResPagesContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
