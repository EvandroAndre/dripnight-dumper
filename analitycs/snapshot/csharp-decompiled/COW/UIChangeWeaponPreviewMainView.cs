using GCommon;
using UnityEngine;

namespace COW;

public class UIChangeWeaponPreviewMainView : UIBaseView
{
	public Transform SkinStats;

	public UIEasyList Grid;

	public UIPanel PanelPrivilege;

	public UIScrollView ScrollViewPrivilege;

	public GameObject WebView;

	public UIButton ButtonWebView;

	public UIButton ButtonAvatarSwitch;

	public UISprite SpriteAvatarSwitchIcon;

	public Transform Property;

	public GameObject AvatarSwitch;

	public UIWidget PreviewBorder;

	public UIWidget WidgetPreview;

	public GameObject EventTrigger;

	public UIGrid GridRightButton;

	public UINetworkTexture BG;

	public UIPanel UIChangeWeaponPreviewMain;

	public Transform WeaponModelDownloader;

	public UILabel OrangePlusWeaponName;

	public UISprite LineNormal;

	public UISprite LinePlus;

	public VFXCreateHelper BGEffectForOrangePlusWeapon;

	public UISprite IpTag;

	public GameObject FeatureDesc;

	public Transform FeatureIconTransform;

	public UILabel LabelFeatureDesc;

	public GameObject Magnifier;

	public UIButton ButtonMagnifier;

	public GameObject IconZoomOut;

	public GameObject IconZoomIn;

	public GameObject FinishMoveContainer;

	public UIButton FinishMoveJumpBtn;

	public Transform ScopeSelectPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
