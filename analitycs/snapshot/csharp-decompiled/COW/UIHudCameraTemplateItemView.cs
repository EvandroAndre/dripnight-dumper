using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraTemplateItemView : UIBaseView
{
	public UIButton ChooseBtn;

	public GameObject ChooseSprite;

	public UILabel NameLabel;

	public UITexture TextureCDN;

	public UINetworkTextureExt CDN;

	public UILabel DurationLabel;

	public GameObject LimitedContiner;

	public GameObject MulitCameraContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
