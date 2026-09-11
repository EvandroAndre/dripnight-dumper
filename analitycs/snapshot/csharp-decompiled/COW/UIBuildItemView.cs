using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildItemView : UIBaseView
{
	public UIButton ClickBtn;

	public GameObject UnSelected;

	public UILabel UnSelectedLabel;

	public UILabel UnSelectedNumLabel;

	public GameObject Selected;

	public UILabel SelectedLabel;

	public UILabel SelectedNumLabel;

	public UISprite AvatarSprite;

	public UIButton RenameBtn;

	public UILabel AutoModeLabel;

	public UITable LabelTable;

	public GameObject UIFX_UIBuildNavigation_Left;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
