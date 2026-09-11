using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabItemView : UIBaseView
{
	public Animation Anim;

	public UISprite DownArrow;

	public UISprite UpArrow;

	public GameObject Select;

	public UILabel SelectLabel;

	public GameObject UnFolded;

	public UILabel UnFoldedLabel;

	public GameObject UnSelect;

	public UISprite UnSelectWidget;

	public UILabel UnSelectLabel;

	public UITipsButton RedPoint;

	public GameObject Tag;

	public UILabel TagLabel;

	public UISprite TagIconBg;

	public UISprite TagIcon;

	public UIButton Button;

	public UIWidget ButtonWidget;

	public GameObject DrawerFixRect;

	public UISprite SelectSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
