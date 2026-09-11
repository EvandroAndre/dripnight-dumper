namespace COW;

public enum OTPState
{
	None,
	ChooseVerifyAccess,
	VerifyEmail,
	VerifyPhone,
	SetPassword,
	SavePassword,
	BindSuccess,
	VerifyPassword,
	ForgetPasswordVerifyEmail,
	ForgetPasswordVerifyPhone,
	Warning,
	ChooseSwapAccess,
	SwapVerifyEmail,
	SwapVerifyPhone,
	AccountInfomation,
	CoolDownWarning
}
