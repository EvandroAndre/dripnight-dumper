using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseLoadoutSideItemView : UIBaseView
{
	public GameObject PlayCardContainer;

	public UISprite EmptyMask;

	public GameObject EquipedArrow;

	public UILabel QuantityLabel;

	public UISprite ItemSprite;

	public GameObject SelectedHightLight;

	public UIButton ItemBtn;

	public UIWidget ItemBtnWidget;

	public GameObject Bg;

	public GameObject AdjustRedDot;

	public UICountDownLabel PlayCardCountDownLabel;

	public GameObject LockMask;

	public GameObject ChangeStatusPos;

	public GameObject LockIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
