using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunSpecialGiftPopupWndView : UIBaseView
{
	public GameObject Content;

	public GameObject BGContainer;

	public UIButton ButtonBG;

	public UILabel LabelSpecialGift;

	public UILabel LabelSpecialGiftShadow;

	public UILabel LabelThankYou;

	public UILabel LabelEvoGunTokenDesc;

	public UILabel LabelTapToClose;

	public Transform TransTokenItem;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
