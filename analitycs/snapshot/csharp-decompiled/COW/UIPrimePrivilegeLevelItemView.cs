using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimePrivilegeLevelItemView : UIBaseView
{
	public UIGrid ExpandGrid;

	public UIGrid ShrinkGrid;

	public UILabel DescLabel;

	public UIProgressBar ProgressBarLeft;

	public UIColor ProgressFgLeft;

	public UIColor ProgressBgLeft;

	public GameObject NotOwned;

	public GameObject Owned;

	public UIProgressBar ProgressBarRight;

	public UIColor ProgressFgRight;

	public UIColor ProgressBgRight;

	public GameObject MaxLevelContainer;

	public UISprite MaxBg;

	public UISprite ProgressBgMaxLeft;

	public UIColor ProgressBgMaxRight;

	public GameObject DecoStartingPoint;

	public UILabel DescOwnedLabel;

	public UILabel DescMaxLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
