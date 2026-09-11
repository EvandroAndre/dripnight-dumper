using GCommon;
using UnityEngine;

namespace COW;

public class UIModeEditPanelView : UIBaseView
{
	public UIButton CloseBtn;

	public UILabel LabelTitle;

	public UIScrollView ScrollViewPanel;

	public UIEasyList TabContainer;

	public UIPanel CContainer;

	public UIButton BtnReset;

	public UIButton BtnOK;

	public UIButton HelpBtn;

	public GameObject EditBtns;

	public UIButton SwitchModeBtn;

	public UIPanel BgTexture;

	public GameObject FeedBack;

	public UIButton FeedBackBtn;

	public GameObject EnableLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
