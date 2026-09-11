using System;
using GCommon;
using proto;

namespace COW;

public class UIPrimeGachaCountDownController : UIBaseController
{
	private ulong m_EndTime;

	private UIPrimeGachaCountDownView m_View;

	private MutableString m_CountDownString;

	private EGachaPrimeCountDownStyle m_CurrentStyle;

	private Action m_CountDownFinishedCallBack;

	private uint m_DelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(EGachaPrimeCountDownStyle style, ClientChestType chestInfo, Action onCountDownFinished = null)
	{
	}

	public void SetViewData(EGachaPrimeCountDownStyle style, long primeStartTime, long startTimeStamp, Action onCountDownFinished = null)
	{
	}

	public string NowCountDownTimeStr(ulong endTime)
	{
		return null;
	}

	private void RefreshCountDownText()
	{
	}

	private void OnCountDownFinished()
	{
	}

	public void Cancel()
	{
	}

	public bool IsDuringCountDown()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
