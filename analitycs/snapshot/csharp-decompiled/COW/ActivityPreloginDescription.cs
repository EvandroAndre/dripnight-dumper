using System;
using GCommon;

namespace COW;

public class ActivityPreloginDescription : ActivityAwardDescription
{
	private enum OperateStatus
	{
		None,
		Book,
		Booked,
		Available,
		Received
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__3_0;

		internal void _003COnOperate_003Eb__3_0(HttpErrorCode errCode, object obj)
		{
		}
	}

	private OperateStatus m_OperateStatus;

	protected override void SetOperateButtonUI()
	{
	}

	protected override void OnOperate()
	{
	}

	public void _003C_003EiFixBaseProxy_SetOperateButtonUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOperate()
	{
	}
}
