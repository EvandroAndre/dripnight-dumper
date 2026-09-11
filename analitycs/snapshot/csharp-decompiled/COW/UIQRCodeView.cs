using GCommon;
using UnityEngine;

namespace COW;

public class UIQRCodeView : UIBaseView
{
	public UITexture CodeTexture;

	public GameObject Mask;

	public GameObject RefreshContainer;

	public GameObject ExpireStateContainer;

	public Transform RefreshVFXTransform;

	public UIPanel QRCodePanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
