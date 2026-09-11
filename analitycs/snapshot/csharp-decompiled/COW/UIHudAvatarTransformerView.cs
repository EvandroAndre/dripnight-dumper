using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAvatarTransformerView : UIBaseView
{
	public UIButton TransformBtn;

	public VFXCreateHelper Transforming;

	public GameObject download;

	public UIWidget GuideWidget;

	public GameObject CircleState;

	public GameObject Select;

	public GameObject Select1;

	public UISprite TransformSprite;

	public Transform DownloadTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
