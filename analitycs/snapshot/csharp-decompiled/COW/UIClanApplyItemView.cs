using GCommon;
using UnityEngine;

namespace COW;

public class UIClanApplyItemView : UIBaseView
{
	public Transform AccountInfoPosition;

	public GameObject ApplyBtnGroup;

	public UIButton BtnComfirm;

	public UIButton BtnRefuse;

	public UILabel SourceLabel;

	public UILabel PromotionLabel;

	public UITable SourceTable;

	public Transform BRIconPosition;

	public Transform CSIconPosition;

	public GameObject PromotionLabelContainer;

	public UIButton FriendIconBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
