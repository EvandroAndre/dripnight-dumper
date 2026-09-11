using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardSubTabItemView : UIBaseView
{
	public UIButton BtnTab;

	public GameObject Select;

	public UILabel SelectLabel;

	public GameObject UnSelect;

	public UILabel UnSelectLabel;

	public GameObject Tag;

	public UILabel TagLabel;

	public UISprite TagIconBg;

	public UISprite TagIcon;

	public UITipsButton RedPoint;

	public Transform Lock;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
