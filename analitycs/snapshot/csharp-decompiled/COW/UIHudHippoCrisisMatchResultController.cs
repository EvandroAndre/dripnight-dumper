using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudHippoCrisisMatchResultController : UIHudNormalMatchResultController
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public ulong localID;

		internal bool _003CCreateShowAvatarPlayerData_003Eb__0(PlayerData e)
		{
			return false;
		}
	}

	private sealed class _003CShowHippoCrisisInventoryGuide_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudHippoCrisisMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowHippoCrisisInventoryGuide_003Ed__4(int _003C_003E1__state)
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

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool IsNeedShowAvatar()
	{
		return false;
	}

	protected override bool IsShowDetailBtn()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	private IEnumerator ShowHippoCrisisInventoryGuide()
	{
		return null;
	}

	protected override void OnClickNextBtn()
	{
	}

	protected override void OnClickModeNextBtn()
	{
	}

	protected override bool IsShowWin()
	{
		return false;
	}

	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsShowDetailBtn()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnClickNextBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickModeNextBtn()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsShowWin()
	{
		return false;
	}

	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}
}
