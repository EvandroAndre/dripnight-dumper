using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTC_DecipherPopupWndView : UIBaseView
{
	public GameObject UIBigEvent_CustomTC_DecipherPopupWnd;

	public UIButton DecipherBtn;

	public UINetworkTexture DecipherBtnSprite;

	public UICenterTargetHelper TokenCenter;

	public UILabel DecipherLabel;

	public UISprite TokenIcon;

	public UILabel TokenCount;

	public UIButton CancelBtn;

	public UINetworkTexture CancelBtnSprite;

	public UILabel CancelLabel;

	public UIButton ClickMask;

	public UINetworkTexture BgTexture;

	public UINetworkTexture SuccessBG;

	public Transform DecipherVFX;

	public Transform SucccessVFX;

	public UILabel ProgressLabel;

	public UILabel PerfectLabel;

	public UINetworkTexture ItemTexture;

	public UILabel SuccessLabel;

	public UINetworkTexture PerfectBg;

	public GameObject SuccessRoot;

	public UILabel PerfectNum;

	public Animation DecipherAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
