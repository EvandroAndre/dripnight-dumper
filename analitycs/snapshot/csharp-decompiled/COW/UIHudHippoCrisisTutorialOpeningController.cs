using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisTutorialOpeningController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIHudHippoCrisisTutorialOpeningController _003C_003E4__this;

		public Vector2 fitSize;

		internal void _003CUpdateCDN_003Eb__0()
		{
		}
	}

	private sealed class _003CCoStartGuide_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudHippoCrisisTutorialOpeningController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoStartGuide_003Ed__11(int _003C_003E1__state)
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

	private UIHudHippoCrisisTutorialOpeningView m_View;

	private List<int> m_GuideTypeLst;

	private UINetworkTexture m_CDNTxture;

	private int mCurGuideIdx;

	private List<ResourceID> m_VoiceRes;

	private const string VOICE_PREFIX = "SOUND_HIPPOCRISIS_TIP{0}_F_{1}";

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

	private void InitVoiceRes()
	{
	}

	public void StartGuide()
	{
	}

	private IEnumerator CoStartGuide()
	{
		return null;
	}

	private void UpdateCDN()
	{
	}

	private void OnNextGuide()
	{
	}

	private void PlayVoice()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
