using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGCLevelEndShowController : UIHUDUGC_InternalHudController
{
	public class UGCLevelEndShowData
	{
		public float WinShowTime;

		public float RoundEndShowTime;

		public bool IsShowWin;

		public bool IsShowLevelEnd;

		public int Rank;

		public int RankMax;

		public int Score;
	}

	private sealed class _003CDelayShowCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDUGCLevelEndShowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowCoroutine_003Ed__8(int _003C_003E1__state)
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

	private UIHUDRushingPetsLevelEndShowView _view;

	private UGCLevelEndShowData _viewData;

	private Coroutine _delayCorHandler;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _ApplyViewData()
	{
	}

	private IEnumerator DelayShowCoroutine()
	{
		return null;
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
