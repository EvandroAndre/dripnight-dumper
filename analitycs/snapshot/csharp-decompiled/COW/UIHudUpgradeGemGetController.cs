using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudUpgradeGemGetController : UIBaseController
{
	public class GEventUpgradeGemGet : GEvent
	{
		public DCGENOPBOEE GemType;

		public uint GemCnt;

		public bool FragmentToOne;

		public bool LevelUp;

		public bool ReachMax;

		public void Reset(DCGENOPBOEE gemType, uint gemCnt, bool fragmentToOne, bool levelUp, bool reachMax)
		{
		}
	}

	private enum EGemGetPlayType
	{
		PlayNone,
		Fragment,
		Complete,
		LevelUp
	}

	private class GemGetPlayData
	{
		public EGemGetPlayType PlayType;

		public byte PrevFragCnt;

		public byte CurFragCnt;

		public byte PrevCompleteCnt;

		public byte CurCompleteCnt;

		public byte Level;

		public byte CurLevelNeedGem;

		public override string ToString()
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_ToString()
		{
			return null;
		}
	}

	private sealed class _003CPlayAbilityGetCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUpgradeGemGetController _003C_003E4__this;

		public GemGetPlayData data;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAbilityGetCoroutine_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CPlayCompleteGetCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUpgradeGemGetController _003C_003E4__this;

		public GemGetPlayData data;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayCompleteGetCoroutine_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CPlayFragmentGetCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUpgradeGemGetController _003C_003E4__this;

		public GemGetPlayData data;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayFragmentGetCoroutine_003Ed__21(int _003C_003E1__state)
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

	private static GEventUpgradeGemGet m_GEventUpgradeGemGet;

	private UIHudUpgradeGemGetView m_View;

	private Queue<GemGetPlayData> m_GemGetPlayDataQueue;

	private Queue<GemGetPlayData> m_GemGetPlayDataPool;

	private uint m_LoadoutID;

	private EGemGetPlayType m_CurrentPlayType;

	private float m_AbilityAimInTime;

	private float m_AbilityAimOutTime;

	public static GEventUpgradeGemGet GetGEvent()
	{
		return null;
	}

	private GemGetPlayData GetGemGetPlayData()
	{
		return null;
	}

	private void ReturnGemGetPlayData(GemGetPlayData data)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnUpgradeGemGet(GEvent evt)
	{
	}

	public void CheckAndPlay()
	{
	}

	private void PlayGemGet(GemGetPlayData data)
	{
	}

	private void PlayFragmentGet(GemGetPlayData data)
	{
	}

	private IEnumerator PlayFragmentGetCoroutine(GemGetPlayData data)
	{
		return null;
	}

	private void PlayCompleteGet(GemGetPlayData data)
	{
	}

	private IEnumerator PlayCompleteGetCoroutine(GemGetPlayData data)
	{
		return null;
	}

	private void PlayLevelUp(GemGetPlayData data)
	{
	}

	private IEnumerator PlayAbilityGetCoroutine(GemGetPlayData data)
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
