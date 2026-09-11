using GCommon;
using UnityEngine;

namespace COW;

public class UIOTPVerifyEmailView : UIBaseView
{
	public GameObject UIOTPVerifyEmail;

	public UIButton BtnConfirm;

	public UIInput InputEmail;

	public UIInput InputVerifyCode;

	public UIButton SendVerifyCodeBtn;

	public GameObject CannotSendVerifyCode;

	public UICountDownLabel SendVerifyCodeCD;

	public UILabel VerifyCodeErrorLabel;

	public UILabel DescLabel;

	public UILabel EmailLabel;

	public UILabel RemindLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
