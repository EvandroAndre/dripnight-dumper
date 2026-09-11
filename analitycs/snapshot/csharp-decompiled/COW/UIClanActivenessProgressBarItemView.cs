using GCommon;
using UnityEngine;

namespace COW;

public class UIClanActivenessProgressBarItemView : UIBaseView
{
	public UIProgressBar ProgressBar;

	public UIButton ProgressAwardBtn;

	public UILabel ProgressLabel;

	public UIProgressBar ActiveProgressBar;

	public UILabel ActiveProgressLabel;

	public UIButton ActiveProgressAwardBtn;

	public GameObject ActiveContainer;

	public GameObject ClanContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
