using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ObjectEntityAttributeEditView : UIBaseView
{
	public UIButton addBtn;

	public UIEasyList AttributeGrid;

	public GameObject Empty;

	public UIButton Attribute;

	public UIButton Info;

	public GameObject AttributeRoot;

	public GameObject InfoRoot;

	public UILabel InfoDes;

	public UIButton ConfirmBtn;

	public UISprite AddBtnBg;

	public UILabel AddBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
