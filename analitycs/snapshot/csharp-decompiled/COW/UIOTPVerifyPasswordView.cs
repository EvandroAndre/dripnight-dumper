using GCommon;
using UnityEngine;

namespace COW;

public class UIOTPVerifyPasswordView : UIBaseView
{
	public GameObject UIOTPVerifyPassword;

	public UIButton ForgetPasswordBtn;

	public UIButton BtnConfirm;

	public GameObject ErrorLabel;

	public UIInput InputPhoneOrEmail;

	public UIInput InputPassword;

	public UIButton EyeBtn;

	public UISprite EyeSprite;

	public UILabel PhoneOrEmailDesc;

	public UILabel RemindLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
