using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityProgressNodeItemTemplateView : UIBaseView
{
	public UIWidget Bounds;

	public GameObject BreeathVFX;

	public UISprite ProgressBarFront;

	public UIProgressBar ProgressBar;

	public UILabel DiamondCountLabel;

	public Transform DiamondCountLabelNormalTrans;

	public Transform DiamondCountLabelLastTrans;

	public GameObject ItemRoot;

	public UINetworkTexture ProgressBarFrontCnd;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
