using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopTagsItemView : UIBaseView
{
	public UILabel NormalTxt;

	public GameObject Normal;

	public GameObject Selected;

	public UILabel SelectedTxt;

	public UISprite SelectedBG;

	public UISprite NormalBG;

	public UIButton Btn;

	public UIWidget ItemWidget;

	public UIDragScrollView ItemUIDragScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
