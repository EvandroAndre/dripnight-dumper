using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPocketReviveSelectCandidateItemView : UIBaseView
{
	public UIButton SelectedButton;

	public GameObject SingleSelectMode;

	public GameObject MultiSelectMode;

	public GameObject SingleSelected;

	public GameObject SingleNotSelected;

	public GameObject MultiSelected;

	public GameObject MultiNotSelected;

	public UILabel PlayerName;

	public UISprite TeamIndexBG;

	public UILabel TeamIndexLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
