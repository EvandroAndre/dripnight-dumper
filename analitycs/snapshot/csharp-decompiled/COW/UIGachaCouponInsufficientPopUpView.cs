using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaCouponInsufficientPopUpView : UIBaseView
{
	public GameObject MultiObtainChannels;

	public GameObject OneObtainChannel;

	public GameObject NoObtainChannel;

	public UILabel MultiObtainChannelsLabel;

	public UIGrid Grid;

	public UILabel OneObtainChannelLabel;

	public UIButton OneObtainOkBtn;

	public UIButton OneObtainGotoBtn;

	public UIButton MultiObtainOKBtn;

	public UILabel NoObtainChannelLabel;

	public UIButton NoObtainOKBtn;

	public UIButton MultiObtainGotoBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
