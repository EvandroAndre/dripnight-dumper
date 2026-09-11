using GCommon;
using UnityEngine;

namespace COW;

public class UIAccountIDNickNameLoginWindowView : UIBaseView
{
	public UIButton BtnClose;

	public UILabel LabelTitle;

	public UILabel LabelNewNameTitle;

	public UIInput InputNewName;

	public UILabel LabelPrice;

	public UIButton BtnConfirm;

	public UISprite ConfirmBtnBg;

	public Transform ServerListNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
