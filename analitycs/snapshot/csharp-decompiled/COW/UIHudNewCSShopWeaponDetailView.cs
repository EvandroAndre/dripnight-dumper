using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNewCSShopWeaponDetailView : UIBaseView
{
	public UILabel WeaponName;

	public UITable Table;

	public UITable TagTable;

	public UILabel Desc;

	public UISprite BG;

	public UIButton CloseBtn;

	public Animation Anim;

	public UILabel ItemType;

	public UITable PropertyTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
