using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditSettingPanelView : UIBaseView
{
	public UIButton CloseBtn;

	public TweenPosition TweenPos;

	public UIButton RemoveBtn;

	public UIButton ModeSettingBtn;

	public UISprite DefaultIcon;

	public UIButton BigCloseBtn;

	public UILabel EditModeName;

	public UISlider Slider1;

	public UITable Grid;

	public UIButton Tip2;

	public UIButton Tip3;

	public UIButton GraphEditBtn;

	public UIWidget Menu;

	public UIPanel BasicScrollView;

	public UIButton ShopEditBtn;

	public Transform ShopMenuTrans;

	public GameObject PopMenuItemShop;

	public UIButton EcoTIps;

	public UIButton Tip6;

	public UIButton Tip8;

	public UISprite BtnDesGuide;

	public UIToggleButtonGroup ToggleEditMode;

	public GameObject EditMode;

	public UIButton TipsEditMode;

	public UIButton BtnHudDesc;

	public UIToggleButton ToggleHudDesc;

	public UIButton BtnGrid;

	public UIToggleButton ToggleGrid;

	public UIButton BtnFriendGroupInvitation;

	public UIToggleButton ToggleFriendGroupInvitation;

	public UIButton BtnDepthMapMode;

	public UIToggleButton ToggleDepthMapMode;

	public UIToggleButtonGroup SetUpTabToggleGroup;

	public UIPanel GamePlayScrollView;

	public UILabel LabelTitle;

	public UIButton BtnSwitchMode;

	public UITable GameplayGrid;

	public BoxCollider scrollable;

	public BoxCollider scrollableGameplay;

	public GameObject BasicIcon;

	public GameObject GameplayIcon;

	public UINetworkTextureExt TextureDrag;

	public UINetworkTextureExt TextureClick;

	public UIUnBlockOtherHudScript UnBlockOtherHudScript;

	public GameObject SwitchGrid;

	public UISprite SwitchGridBG;

	public GameObject GridGranularity;

	public UISprite GirdGranularutyBG;

	public GameObject SwitchDepthMapMode;

	public UISprite SwitchDepthMapBG;

	public GameObject BtnClearScene;

	public UISprite BtnClearSceneBG;

	public GameObject CameraSpeedItem;

	public UISprite CameraSpeedBG;

	public GameObject SwitchAIAssist;

	public UIButton BtnAIAssist;

	public UIToggleButton ToggleAIAssist;

	public UIInput SliderInput;

	public GameObject SwitchGridSnap;

	public UISprite SwitchGridSnapBG;

	public UIButton SwitchGridSnapTip;

	public UIButton BtnSwitchGridSnap;

	public UIToggleButton ToggleGridSnap;

	public UIToggleButton ToggleAim;

	public UIToggleButton TogglePick;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
