using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFastPreviewView : UIBaseView
{
	public GameObject Chosen;

	public UILabel ChosenHudName;

	public UIButton CustomizeButton;

	public GameObject NotChosen;

	public UILabel NotChosenHudName;

	public UIButton ChooseBtn;

	public GameObject Top;

	public GameObject TopLeft;

	public GameObject Left;

	public GameObject TopRight;

	public GameObject BottomLeft;

	public GameObject BottomRight;

	public GameObject Bottom;

	public EdgeDetectHudItem UIHudGrenade;

	public CustomHudExpandDirection GrenadeDirectionRight;

	public CustomHudExpandDirection GrenadeDirectionLeft;

	public CustomHudExpandDirection GrenadeDirectionTop;

	public CustomHudExpandDirection GrenadeDirectionBottom;

	public GameObject HudCustomContent;

	public UIPanel ChooseContainer;

	public UIWidget BoundWidget;

	public UIPanel HudCustomContentPanel;

	public UISprite ChosenBG;

	public VFXCreateHelper ChosenUIFX;

	public CustomHudItem HudReloadBtn;

	public CustomHudItem HudSwapWeaponQuick;

	public GameObject UIHudGrenadeBtn2;

	public UIPanel PanelPreview;

	public UIButton BackButton;

	public GameObject GreyMaskBG;

	public UI2DSprite BG;

	public UIMultiresolutionFit BGFit;

	public UIWidget TableBounds;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
