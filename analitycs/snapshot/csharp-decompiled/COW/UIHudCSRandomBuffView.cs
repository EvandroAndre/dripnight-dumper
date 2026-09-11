using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSRandomBuffView : UIBaseView
{
	public UIButton BtnClose;

	public UIButton BtnConfirm;

	public GameObject ConfirmEnabled;

	public GameObject ConfirmDisabled;

	public UILabel LabelPlayerLevel;

	public UITable Table;

	public UIGrid GridNewAttribute;

	public UIGrid GridOwnedAttribute;

	public GameObject NewAttribute;

	public GameObject OwnedAttribute;

	public UILabel Tips;

	public UIButton BtnRerandom;

	public UILabel RerandomCntDesc;

	public UIButton Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
