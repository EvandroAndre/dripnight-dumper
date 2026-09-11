using GCommon;
using UnityEngine;

namespace COW;

public class UIOTPSetPasswordView : UIBaseView
{
	public GameObject UIOTPSetPassword;

	public UIButton ConfirmBtn;

	public UIInput InputPassword;

	public UIInput InputPasswordSecond;

	public UILabel BindPhoneOrEmailLabel;

	public UIButton PasswordSecondEyeBtn;

	public GameObject PasswordRemindLabel;

	public UIButton PasswordEyeBtn;

	public UISprite PasswordEyeSprite;

	public UISprite PasswordSecondEyeSprite;

	public UILabel RemindLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
