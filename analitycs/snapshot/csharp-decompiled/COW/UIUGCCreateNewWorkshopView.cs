using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCreateNewWorkshopView : UIBaseView
{
	public UIEasyList ModeGridEasyList;

	public UIButton BtnApply;

	public UINetworkTexture CDNBg;

	public UIToggleButton BtnTemplate;

	public UIToggleButton BtnClassic;

	public UIButton WebTutorial;

	public GameObject GoLevelLimited;

	public UIButton BtnLimited;

	public UIButton GoToRewardButton;

	public UILabel LabelLevel;

	public UILabel ChooseMap;

	public UIGrid MapGrid;

	public GameObject Map;

	public UILabel MapNameLabel;

	public UIInput MapNameInput;

	public UILabel Name;

	public UILabel DescLabel;

	public UIScrollView MapSV;

	public UIScrollView LabelSV;

	public UINetworkTexture TemplateCDNBg;

	public GameObject TemplateCdns;

	public UINetworkTexture CDN1;

	public UINetworkTexture CDN2;

	public UINetworkTexture CDN3;

	public UIGrid OverviewGrid;

	public UIScrollView OverviewSV;

	public GameObject Right;

	public GameObject LoadingObj;

	public UIButton BeginnerGuideBtn;

	public UIDragDropItem UGCTutorialDragItem;

	public Transform BtnTutorialDownloadContainer;

	public UIWidget UIDragWidgetBounds;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
