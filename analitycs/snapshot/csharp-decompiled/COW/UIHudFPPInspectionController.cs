using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudFPPInspectionController : UIHudButtonBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<uint, string> _003C_003E9__10_0;

		internal string _003CSetTutorialFinished_003Eb__10_0(uint value)
		{
			return null;
		}
	}

	private UIHudFPPInspectionView m_View;

	private uint m_DelayCall;

	private List<uint> m_GuideFinishiedGameModes;

	private uint m_UGCPhaseIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnStartNewPhase(object[] data)
	{
	}

	private void OnUgcPhaseChange(object[] data)
	{
	}

	private void TryTutorial()
	{
	}

	private bool IsTutorialFinised()
	{
		return false;
	}

	private void SetTutorialFinished()
	{
	}

	private List<uint> ParseStringToUintList(string input)
	{
		return null;
	}

	private void OnBtnFPPInspectionClick()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void _003CTryTutorial_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
