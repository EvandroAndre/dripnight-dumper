using GCommon;
using UnityEngine;

namespace COW;

public class UIFullScreenPreviewView : UIBaseView
{
	public UINetworkTexture BG;

	public UIPanel PanelMaxDepth;

	public UIWidget PreviewBorder;

	public UIPanel UIFullScreenPreview;

	public VFXCreateHelper BGEffectForMaterialWeapon;

	public GameObject DefaultBgShowInWeaponAnim;

	public UIButton NB2ShareBtn;

	public UINetworkTextureExt NB2ScreenShotBg;

	public UICamera FeatureBtnCamera;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
