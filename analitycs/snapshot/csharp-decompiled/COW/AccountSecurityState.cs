namespace COW;

public enum AccountSecurityState
{
	None,
	Guest,
	BindPlatformOnly,
	WaitforBind,
	WaitforUnbind,
	WaitforRebind,
	AllBindingInLock,
	AllBinding
}
