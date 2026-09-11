using UnityEngine;

namespace COW;

public class UIHudAvatarTransformerBaseView
{
	public VFXCreateHelper TransformingVFX;

	public UIButton TransformerBtn;

	public UISprite TransformerSprite;

	public GameObject Download;

	public UIWidget GuideWidget;

	public Transform DownloadTrans;

	public UIHudAvatarTransformerBaseView(UIHudAvatarTransformerView view)
	{
	}

	public UIHudAvatarTransformerBaseView(UIHudAvatarTransformerFreeMultiView view)
	{
	}
}
