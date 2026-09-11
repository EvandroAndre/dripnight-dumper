using UnityEngine;

namespace COW;

public class UILobbyAvatarTransformerBaseView
{
	public VFXCreateHelper TransformingVFX;

	public UIButton TransformerBtn;

	public UISprite TransformerSprite;

	public GameObject Download;

	public Transform DownloadTrans;

	public UIWidget GuideWidget;

	public UILobbyAvatarTransformerBaseView(UILobbyAvatarTransformerView view)
	{
	}

	public UILobbyAvatarTransformerBaseView(UILobbyAvatarTransformerFreeMultiView view)
	{
	}
}
