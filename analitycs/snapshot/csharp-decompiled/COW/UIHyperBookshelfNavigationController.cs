using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHyperBookshelfNavigationController : UINavigationController, IUIModelDataChangeObserver
{
	private sealed class _003CDelayAdjustScrollViewPivot_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookshelfNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayAdjustScrollViewPivot_003Ed__29(int _003C_003E1__state)
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

	private sealed class _003CDelayShowGuideMask_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookshelfNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowGuideMask_003Ed__35(int _003C_003E1__state)
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

	private sealed class _003CEntranceBookOpenCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookshelfNavigationController _003C_003E4__this;

		public uint bookID;

		public GameObject entranceGo;

		private Vector3 _003CtargetLocalPos_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEntranceBookOpenCoroutine_003Ed__31(int _003C_003E1__state)
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

	public const float ENTRANCE_BOOK_SHAKE_ANIM_DURATION = 1f;

	public const float ENTRANCE_BOOK_OPEN_ANIM_DURATION = 1.1f;

	public const string NAVIGATION_HELP_TIPS_KEY = "T_34_XY_HYPERBOOK_HELP";

	public const string NAVIGATION_TITLE_KEY = "T_34_XY_HYPERBOOK_SYS";

	private const string GUIDE_BOOK_ENTRANCE_KEY = "T_34_XY_HYPERBOOK_SYS";

	private const float ENTRANCE_BOOK_OPEN_TWEEN_OFFSET_Y = 130f;

	private bool m_IsFirstShowed;

	private bool m_IsUnlockAnimPlaying;

	private float m_ShowMaskDuration;

	private uint m_DelayCallID;

	private UIHyperBookshelfNavigationView m_View;

	private Coroutine m_ScrollViewResetPositionCoroutine;

	private Coroutine m_ShowAndHideMaskCoroutine;

	private Coroutine m_EntranceBookOpenCoroutine;

	private GameObject m_EntranceBookOpenVFX;

	private GameObject m_EntranceBookOpenBgVFX;

	private GameObject m_EntranceBookOpenBurstVFX;

	private readonly List<UIHyperBookEntranceController> m_EntranceCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnHyperBookInfoRefresh()
	{
	}

	private void PrepareBookEntrances()
	{
	}

	private void RefreshBookEntrances(bool isFirstEntered)
	{
	}

	private void StartDelayAdjustScrollViewPivot()
	{
	}

	private IEnumerator DelayAdjustScrollViewPivot()
	{
		return null;
	}

	private void StartEntranceBookOpenCoroutine(uint bookID, GameObject entranceGo)
	{
	}

	private IEnumerator EntranceBookOpenCoroutine(uint bookID, GameObject entranceGo)
	{
		return null;
	}

	private void OnEntranceBookOpenFinished()
	{
	}

	public void ShowGuide(UIWidget entranceWidget, uint bookID)
	{
	}

	private void StartDelayShowGuideMask()
	{
	}

	private IEnumerator DelayShowGuideMask()
	{
		return null;
	}

	private void TryStopDelayCall()
	{
	}

	private void DestroyAllRuntimeResource()
	{
	}

	private void LoadEntranceBookOpenBgVFX()
	{
	}

	private void LoadEntranceBookOpenBurstVFX()
	{
	}

	public void OnHyperBookEntranceEnter(uint bookID, GameObject entranceGo)
	{
	}

	private void _003CShowGuide_003Eb__33_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
