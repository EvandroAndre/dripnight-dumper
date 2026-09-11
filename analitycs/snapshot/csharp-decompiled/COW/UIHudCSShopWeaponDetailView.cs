using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSShopWeaponDetailView : UIBaseView
{
	public GameObject Detail;

	public UILabel WeaponType;

	public UILabel WeaponName;

	public UITable Table;

	public UITable TagTable;

	public Object ScrollView;

	public UILabel Desc;

	public UITable ContainerTable;

	public GameObject BUffNode;

	public UISprite IconBuff;

	public UISprite BuffLevel3;

	public UISprite BuffLevel2;

	public UISprite BuffLevel1;

	public UILabel BuffName;

	public UILabel BuffLv;

	public UILabel BuffDesc;

	public UISprite BG;

	public UIScrollView ContainerScroll;

	public GameObject Line;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
