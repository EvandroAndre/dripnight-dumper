using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityAccumulateItemView : UIBaseView
{
	public UIWidget Bounds;

	public GameObject BreeathVFX;

	public UISprite LuckyProgressBarFront;

	public UIProgressBar ProgressBar;

	public UILabel DiamondCountLabel;

	public Transform DiamondCountLabelNormalTrans;

	public Transform DiamondCountLabelLastTrans;

	public GameObject ItemRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
