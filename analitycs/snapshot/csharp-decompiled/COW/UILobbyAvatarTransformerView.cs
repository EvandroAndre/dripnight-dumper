using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyAvatarTransformerView : UIBaseView
{
	public UIButton TransformBtn;

	public VFXCreateHelper Transforming;

	public GameObject download;

	public GameObject CircleState;

	public UIWidget GuideWidget;

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
