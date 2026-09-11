using GCommon;
using UnityEngine;

namespace COW;

public class UIQRCodeScanWindowView : UIBaseView
{
	public UIButton CloseBtn;

	public Transform ScanVFXTransform;

	public GameObject NormalTipsContainer;

	public GameObject ErrorTipsContainer;

	public UITexture CameraTexture;

	public UIButton AlbumBtn;

	public GameObject EffectContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
