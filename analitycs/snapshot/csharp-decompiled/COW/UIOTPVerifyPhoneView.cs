using GCommon;
using UnityEngine;

namespace COW;

public class UIOTPVerifyPhoneView : UIBaseView
{
	public GameObject UIOTPVerifyPhone;

	public UIButton BtnConfirm;

	public UITable Table;

	public UIButton WhatsAppBtn;

	public UIButton SMSBtn;

	public GameObject SelectPhoneVerifyAccess;

	public GameObject WhatsAppSelected;

	public GameObject SMSSelected;

	public UIInput InputVerifyCode;

	public UIButton SendVerifyCodeBtn;

	public GameObject CannotSendVerifyCode;

	public UICountDownLabel SendVerifyCodeCD;

	public UIInput InputPhoneNumber;

	public GameObject AreaNumberContainer;

	public UILabel PhoneRemindLabel;

	public UILabel DescLabel;

	public UIButton TipsBtn;

	public UILabel PhoneNumberLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
