using GCommon;
using UnityEngine;

namespace COW;

public class UIBindPhoneWndView : UIBaseView
{
	public UILabel PhoneNumber;

	public UIButton BtnSendVerifyCode;

	public UICountDownLabel SendVerifyCodeCD;

	public UILabel VerifyCode;

	public UIButton BtnConfirm;

	public GameObject CannotSendVerifyCode;

	public GameObject CannotBindConfirm;

	public UILabel Desc;

	public Transform AreaNumberContainer;

	public GameObject InputNumber;

	public UILabel CheckNumber;

	public UIInput InputPhoneNumber;

	public UILabel SendCodeTimesRemindLabel;

	public UILabel SendCodeLimitedLabel;

	public UIInput InputVerifyCode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
