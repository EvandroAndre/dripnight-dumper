using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal abstract class UIHudPOIMissionInfoBaseController : UIBaseController
{
	protected uint m_POIMissionId;

	protected LevelObjectPOIMission m_POIMission;

	protected GGEHCFFCPAJ m_Module;

	protected MutableString m_CountStr;

	protected UITimeLabelHelper m_StartTimer;

	protected abstract UILabel MissionLabel { get; }

	protected abstract GameObject Available { get; }

	protected abstract GameObject Unavailable { get; }

	protected abstract UILabel UnavailableLabel { get; }

	protected abstract UIButton BtnAccept { get; }

	protected abstract GameObject Countdown { get; }

	protected abstract UILabel TimeLabel { get; }

	protected abstract GameObject ProgressTag { get; }

	protected abstract UILabel ProgressLabel { get; }

	protected override void OnUIInit()
	{
	}

	protected virtual void OnPOIMissionOwnerChanged()
	{
	}

	protected virtual void OnPOIMissionStateChanged(uint poimissionId)
	{
	}

	public virtual void SetData()
	{
	}

	private void OnTimerFinish()
	{
	}

	protected void RefreshAvailableState(LevelObjectPOIMission poimission, GGEHCFFCPAJ module)
	{
	}

	protected virtual void OnBtnAcceptClick()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
