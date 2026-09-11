using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRedEnvelopeReceiveWindowView : UIBaseView
{
	public UILabel LabelOwnerInfo;

	public GameObject ReceiveInfo;

	public RedEnvelopeAwardItemView ReceiveItem;

	public GameObject LabelDone;

	public UIButton BtnOpen;

	public UIButton BtnReceiveInfo;

	public UIButton BtnReceiveInfo2;

	public UIButton BtnClose;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
