using UnityEngine;

namespace COW;

public class FrontEndSceneRootFinder : SceneRootFinder
{
	public Transform UI3DRoot;

	public Transform UIBGRoot;

	public Camera UI3DCamera;

	public Camera UIBGCamera;

	public UITexture BGTexture;

	public UISprite BgDarkMask;

	public Transform Bg2DObjects;

	public Camera UIRootCamera;

	public GameObject ItemLight;
}
