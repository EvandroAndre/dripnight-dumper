using System;
using GCommon;

namespace COW;

internal class UIHudChangeSeatController : UIBaseController
{
	private enum EButtonStage
	{
		Reqeust,
		Confirmation,
		NB
	}

	private class CDData
	{
		public EButtonStage Stage;

		public bool IsInCD;

		public float EndCDGameTime;

		public float Duration;

		public UIProgressBar ProgressBar;

		public Action CDFinished;

		public CDData(EButtonStage stage, UIProgressBar progressBar)
		{
		}

		public bool IsButtonEnable()
		{
			return false;
		}
	}

	private UIHudChangeSeatView m_View;

	private EButtonStage m_CurrentStage;

	private byte m_PendingRequestID;

	private CDData[] m_CDData;

	private uint m_SeatIDOnReq;

	private const uint SEAT_ID_BIAS = 1u;

	private uint m_CDTweenDelay;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnConfirmClick(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void RefreshCD(CDData currentCDData)
	{
	}

	private void OnCannonStateChanged(object[] data)
	{
	}

	private void OnGetOnVehicle(object[] data)
	{
	}

	private void OnAskChangeSeat(object[] data)
	{
	}

	private void OnBtnChangeSeat()
	{
	}

	private void ChangeStage(EButtonStage newStage)
	{
	}

	private void ShowCDTimeTween()
	{
	}

	private void HideCDTimeTween()
	{
	}

	private void _003COnUIInit_003Eb__9_0()
	{
	}

	private void _003COnUIInit_003Eb__9_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
