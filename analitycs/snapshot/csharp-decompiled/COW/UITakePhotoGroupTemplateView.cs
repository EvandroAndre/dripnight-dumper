using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupTemplateView : UIBaseView
{
	public UIEasyList EasyList;

	public Animation main;

	public UIButton ExpandBtn;

	public UIWidget ExpandBtnWidget;

	public UISprite IsExpandIcon;

	public UISprite UnExpandIcon;

	public UIButton Uncheck;

	public UISprite Check;

	public UIPanel ScrollView;

	public UIWidget BG_Container;

	public UIColor Bg;

	public GameObject Check_Container;

	public GameObject PhotoTemplateToggleSelect;

	public GameObject PhotoTemplateToggleUnSelect;

	public GameObject PhotoTemplate;

	public GameObject BackgroundEdit;

	public UITable ToggleTable;

	public UIAnchor ToggleAnchor;

	public UIToggleButton PhotoTemplateBtn;

	public UIToggleButton BackGrouundEditBtn;

	public GameObject BackgroundEditToggleSelect;

	public GameObject BackgroundEditToggleUnSelect;

	public UIPanel ScrollViewGroundEdit;

	public UIEasyList EasyListGroundEdit;

	public UIPanel ScrollViewPhotoBg;

	public GameObject PhotoBg;

	public GameObject PhotoBgToggleSelect;

	public GameObject PhotoBgToggleUnSelect;

	public UIToggleButton PhotoBgBtn;

	public UIEasyList EasyListPhotoBg;

	public Transform BackGroundEditTipsContainer;

	public Transform PhotoTemplateTipsContainer;

	public Transform PhotoBgTipsContainer;

	public UILabel PhotoBgLeftTimeLabel;

	public GameObject PhotoBgLeftTimeContainer;

	public UINetworkTexture BigEvent_FontBg;

	public Transform BigEvent_BgContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
