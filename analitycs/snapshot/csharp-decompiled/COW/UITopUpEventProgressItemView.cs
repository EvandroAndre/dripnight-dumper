using GCommon;
using UnityEngine;

namespace COW;

public class UITopUpEventProgressItemView : UIBaseView
{
	public UIWidget Bounds;

	public GameObject BreeathVFX;

	public UISprite LuckyProgressBarFront;

	public UIProgressBar ProgressBar;

	public UILabel DiamondCountLabel;

	public Transform DiamondCountLabelNormalTrans;

	public Transform DiamondCountLabelLastTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
