using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDPVEBossSubtitleController : UIBaseController
{
	private sealed class _003COnShow_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHUDPVEBossSubtitleController _003C_003E4__this;

		public string content;

		public ResourceID voiceResID;

		public float duration;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnShow_003Ed__5(int _003C_003E1__state)
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

	private HUDPVEBossSubtitleView m_View;

	private bool isPlaying;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnSubtitleInfoCome(string content, ResourceID voiceResID, float duration)
	{
	}

	private IEnumerator OnShow(string content, ResourceID voiceResID, float duration)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
