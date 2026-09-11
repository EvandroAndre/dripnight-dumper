using GCommon;
using UnityEngine;

namespace COW;

public class UIPhotoWallCuttingWndView : UIBaseView
{
	public GameObject UIPhotoWallCuttingWnd;

	public UITexture BGtexture;

	public UITexture CropMask;

	public UISprite TargetFrame;

	public UIButton ConfirmBtn;

	public UIButton ResetBtn;

	public UISprite LimitRange;

	public UINetworkTexture WndBackground;

	public UIButton CloseBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
