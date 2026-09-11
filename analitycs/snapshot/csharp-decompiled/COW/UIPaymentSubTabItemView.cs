using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSubTabItemView : UIBaseView
{
	public UIButton BtnTab;

	public GameObject Select;

	public UILabel SelectLabel;

	public GameObject UnSelect;

	public UILabel UnSelectLabel;

	public GameObject Tag;

	public GameObject NewSprite;

	public GameObject RedPoint;

	public Transform Lock;

	public UILabel TagLabel;

	public UISprite TagIconBg;

	public UISprite TagIcon;

	public GameObject RedDotPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
