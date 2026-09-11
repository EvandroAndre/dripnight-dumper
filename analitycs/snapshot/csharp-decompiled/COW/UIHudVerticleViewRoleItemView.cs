using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVerticleViewRoleItemView : UIBaseView
{
	public UILabel PetName;

	public UILabel PetDesc;

	public GameObject Selected;

	public UIButton UIHudVerticleViewRoleItem;

	public GameObject IsRecommended;

	public GameObject MyIcon;

	public GameObject TeammateIcon;

	public UIGrid SelectedPlayerGrid;

	public UISprite PetSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
