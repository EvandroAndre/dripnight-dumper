using System;
using System.Text;
using GCommon;
using proto;

namespace COW;

public class UIPrimeGachaNoPrimeTipsController : UIBaseController
{
	private UIPrimeGachaNoPrimeTipsView m_View;

	private UIModelPrime m_ModelPrime;

	private EGachaPrimeLimitedTipsStyle m_CurrentStyle;

	private static string LockIconSpriteName;

	private string m_PrimeGachaUnlockLvStr;

	private ulong m_EndTime;

	private uint m_DelayCall;

	private Action m_CountDownFinishedCallBack;

	private StringBuilder m_ClickString;

	public EPrimeLogStyle m_PrimeLogStyle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitBuildV2GoPosString()
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

	public void SetViewData(EGachaPrimeLimitedTipsStyle style, ClientChestType chestInfo, Action onCountDownFinished = null)
	{
	}

	public void SetViewData(EGachaPrimeLimitedTipsStyle style, long primeStartTime, long startTimeStamp, Action onCountDownFinished = null)
	{
	}

	private void OnCountDownFinished()
	{
	}

	public override void Hide()
	{
	}

	private void RefreshCountDownText()
	{
	}

	public void Cancel()
	{
	}

	public bool IsDuringCountDown()
	{
		return false;
	}

	public void SetPrimeLogStyle(EPrimeLogStyle style)
	{
	}

	private void OnGotoBtnClick()
	{
	}

	protected override void OnDestroy()
	{
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

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
