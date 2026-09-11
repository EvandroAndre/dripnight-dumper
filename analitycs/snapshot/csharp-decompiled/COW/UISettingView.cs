using GCommon;
using UnityEngine;

namespace COW;

public class UISettingView : UIBaseView
{
	public UIPanel WindowPanel;

	public GameObject ChangeTabToggle;

	public UITable ChangeTabToggleTable;

	public GameObject BasicNode;

	public UIToggleButton BasicButton;

	public GameObject UGCEditor;

	public UIToggleButton UGCEditorButton;

	public GameObject Graphics;

	public UIToggleButton GraphicsBtn;

	public UIToggleButton SoundButton;

	public GameObject NotificationsTab;

	public UIToggleButton NotificationsButton;

	public GameObject MAXTab;

	public UIToggleButton MAXButton;

	public GameObject MaxRedTips;

	public GameObject DebugInfoTab;

	public UIToggleButton DegbugInfoButton;

	public GameObject OBTab;

	public UIToggleButton OBButton;

	public UISprite bg;

	public GameObject Content;

	public UIButton QuitBtn1;

	public GameObject RegionContainer;

	public UILabel Region;

	public UIToggleButton ReplayKitButton;

	public GameObject ReplayKit;

	public GameObject PCKeyTab;

	public UIToggleButton PCKeyButton;

	public GameObject FPPDebugTab;

	public UIToggleButton FPPButton;

	public UIToggleButton InGameButton;

	public Transform InGame;

	public UIWidget BasicGuideTrans;

	public UIButton LogoutBtn;

	public UILabel LogoutNameLabel;

	public UISprite LogoutIcon;

	public UIWidget LogoutGuideTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
