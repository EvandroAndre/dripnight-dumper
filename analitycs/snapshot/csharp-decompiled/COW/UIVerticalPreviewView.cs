using GCommon;
using UnityEngine;

namespace COW;

public class UIVerticalPreviewView : UIBaseView
{
	public GameObject NormalUIRoot;

	public UIButton ExitBtn;

	public UIButton TakePhotoBtn;

	public UIButton ZoomInOutBtn;

	public UISprite ZoomInOutSpr;

	public GameObject ScreenShotUIRoot;

	public UIWidget PreviewBorder;

	public UISprite ZoomOutSprite;

	public UITexture BG;

	public UINetworkTexture BGNetworkTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
