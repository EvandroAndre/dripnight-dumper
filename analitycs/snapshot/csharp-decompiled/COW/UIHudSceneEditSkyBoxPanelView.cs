using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditSkyBoxPanelView : UIBaseView
{
	public UIButton BtnClose;

	public UITable MainTable;

	public UITable SkyTable;

	public UIScrollView SkyboxSelectorScrollView;

	public UIWrapContent UIWrapContent;

	public UICenterOnChild UICenterOnChild;

	public GameObject GridContainer;

	public UIGrid DotGrid;

	public GameObject DotColor;

	public GameObject SkyBox;

	public UIUnBlockOtherHudScript UnBlockOtherHudScript;

	public UISprite SkyBG;

	public UISprite SkyCollapasedSprite;

	public UITable FogTable;

	public UISprite FogBG;

	public UIButton FogCollapasedBtn;

	public UIButton SkyCollapasedBtn;

	public UISprite FogCollapasedSprite;

	public UIWidget GuideWidget;

	public UIPanel GuidePanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
