using System;
using GCommon;

namespace COW;

internal class UIHudReaperTransformController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool> _003C_003E9__5_0;

		public static Action<bool> _003C_003E9__5_1;

		public static Action<bool> _003C_003E9__5_2;

		internal void _003CUpdateState_003Eb__5_0(bool active)
		{
		}

		internal void _003CUpdateState_003Eb__5_1(bool active)
		{
		}

		internal void _003CUpdateState_003Eb__5_2(bool active)
		{
		}
	}

	private UIHudReaperTransformView m_View;

	private float iconDarkAlpha;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnTransformClick()
	{
	}

	public void UpdateState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
