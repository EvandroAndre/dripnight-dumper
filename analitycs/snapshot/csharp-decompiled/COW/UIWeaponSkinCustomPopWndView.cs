using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomPopWndView : UIBaseView
{
	public UIButton HelpBtn;

	public Transform AttributeFilter;

	public UIPanel CustomAttributePanel;

	public UIScrollView CustomAttributeScrollView;

	public UIPanel CustomAppearancePanel;

	public UIScrollView CustomAppearanceScrollView;

	public UITable2 CustomAttributeList;

	public UIEasyList CustomAppearanceList;

	public UIButton SaveBtn;

	public UIWidget PreviewUI;

	public GameObject EventTrigger;

	public Transform HotFixDownloadPos;

	public GameObject AttributeArrow;

	public GameObject AppearanceArrow;

	public UILabel GunTitleLabel;

	public UIWidget GuideWidgetTip;

	public UIWidget GuideWidgetSelectAttribute;

	public UIWidget GuideWidgetSelectAppearance;

	public Transform TipGuidePos;

	public UILabel TiltleLabel;

	public Transform TopBgContainer;

	public UIButton CloseBtn;

	public GameObject MultiSelectNode;

	public UICheckboxButton MultiCheckButton;

	public UIButton TipsBtn;

	public UILabel MultiSelectLabel;

	public UIWidget MultiSelectGuideNode;

	public UISprite MultiTipsSprite;

	public UILabel AppearanceTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
