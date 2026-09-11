using GCommon;
using UnityEngine;

namespace COW;

public class UIFlashStoreActivityNavigationView : UIBaseView
{
	public UINetworkTexture TitleCDN;

	public UIButton RuleBtn;

	public UILabel TitleDescriptionLabel;

	public UILabel ActivitiesPanelDescLabel;

	public UIScrollView ActivitiesScrollView;

	public UITable ActivitiesTable;

	public UIGrid ProgressPointGrid;

	public UISlider ProgressSlider;

	public UIButton ReceiveAllBtn;

	public GameObject TitleDefaultIcon;

	public UIPanel GuideMaskPanel;

	public UIButton GuideMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
