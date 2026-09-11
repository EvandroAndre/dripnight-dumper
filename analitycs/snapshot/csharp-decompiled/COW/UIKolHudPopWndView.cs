using GCommon;
using UnityEngine;

namespace COW;

public class UIKolHudPopWndView : UIBaseView
{
	public UILabel TitleLabel;

	public UIButton PreviewSensivityEntrance;

	public UIWidget PreviewSensivityEntrancePanel;

	public UIToggle UseSensitivity;

	public GameObject HudRoot;

	public UITable TagTable;

	public UIButton BtnUseHud;

	public UILabel IntroduceLabel;

	public GameObject FilterContainerRoot;

	public UIButton SearchEntrence;

	public GameObject SearchTable;

	public UIInput SearchInput;

	public UIButton SearchButton;

	public UILabel SearchCDLabel;

	public GameObject SearchSprite;

	public UIButton ClearButton;

	public UIButton BackButton;

	public GameObject QRCodeScanBtn;

	public UIInput QRCodeInput;

	public UIScrollView HudList;

	public UIPanel HudListPanel;

	public UIEasyList WrapContent;

	public GameObject RecommendPanel;

	public UIScrollView RecommendHudList;

	public UIPanel RecommendHudListPanel;

	public UIEasyList RecommendWrapContent;

	public GameObject ListEmptyHint;

	public UIWidget GuideRoot;

	public UISprite infoicon;

	public UISprite SensitivitySprite;

	public UIButton InfoButton;

	public UIPanel PanelPreview;

	public UIButton PreviewButton;

	public UIButton ScanQRButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
