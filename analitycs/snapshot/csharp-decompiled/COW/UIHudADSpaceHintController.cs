using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudADSpaceHintController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public IIMKIFFPIOF game;

		internal void _003CShowHint_003Eb__0()
		{
		}
	}

	private UIHudADSpaceHintView m_View;

	private uint m_HideDelayCall;

	private Queue<ADSHintStyle> showHintQueue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void DeActiveAll()
	{
	}

	private void OnStart1v1InfoChange()
	{
	}

	private float DurationForADSHintStyle(ADSHintStyle style)
	{
		return 0f;
	}

	public void SetData(ADSHintStyle style)
	{
	}

	private void ShowNextHint()
	{
	}

	private void ShowHint(ADSHintStyle hintStyle)
	{
	}

	private void _003CSetData_003Eb__8_0()
	{
	}

	private void _003CShowNextHint_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
