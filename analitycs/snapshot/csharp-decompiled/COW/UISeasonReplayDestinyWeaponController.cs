using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISeasonReplayDestinyWeaponController : UIBaseController, IUISeasonReplayItem
{
	private sealed class _003CDelayedAction_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action action;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayedAction_003Ed__12(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIModelSeasonReplay m_ModelSeasonReplay;

	private UISeasonReplayDestinyWeaponOneController m_OneCtrl;

	private UISeasonReplayDestinyWeaponTwoController m_TwoCtrl;

	private UISeasonReplayDestinyWeaponThreeController m_ThreeCtrl;

	public static Dictionary<uint, string> DicWeaponTag_Key;

	private bool m_IsBR;

	private EDestinyWeaponType m_PreviewType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	static UISeasonReplayDestinyWeaponController()
	{
	}

	protected override void OnUIInit()
	{
	}

	public void Init(bool isBR)
	{
	}

	public void Selected(bool isFirstEnter)
	{
	}

	private IEnumerator DelayedAction(Action action)
	{
		return null;
	}

	public void UnSelected()
	{
	}

	public void HidePreview()
	{
	}

	public void RecoverPreview()
	{
	}

	public void HideView()
	{
	}

	public CombineScreenshotData BeforeCombineShare()
	{
		return default(CombineScreenshotData);
	}

	public void AfterCombineShare()
	{
	}

	public void PrepareControllerBeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
