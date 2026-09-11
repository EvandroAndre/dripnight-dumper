using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAudio.Core;

public static class AudioSourceExtension
{
	private sealed class _003CPause_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public float fadeTime;

		public Action onFadeEnd;

		private float _003CinitialVolume_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPause_003Ed__2(int _003C_003E1__state)
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

	private sealed class _003CPlay_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public float fadeTime;

		public Action onFadeEnd;

		private float _003CtargetVolume_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlay_003Ed__0(int _003C_003E1__state)
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

	private sealed class _003CResume_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public float fadeTime;

		public Action onFadeEnd;

		private float _003CtargetVolume_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResume_003Ed__3(int _003C_003E1__state)
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

	private sealed class _003CSetVolume_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public float targetVolume;

		public float fadeTime;

		private float _003CsourceVolume_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetVolume_003Ed__4(int _003C_003E1__state)
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

	private sealed class _003CStop_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public float fadeTime;

		public Action onFadeEnd;

		private float _003CinitialVolume_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStop_003Ed__1(int _003C_003E1__state)
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

	public static IEnumerator Play(AudioSource source, float fadeTime, Action onFadeEnd = null)
	{
		return null;
	}

	public static IEnumerator Stop(AudioSource source, float fadeTime, Action onFadeEnd = null)
	{
		return null;
	}

	public static IEnumerator Pause(AudioSource source, float fadeTime, Action onFadeEnd = null)
	{
		return null;
	}

	public static IEnumerator Resume(AudioSource source, float fadeTime, Action onFadeEnd = null)
	{
		return null;
	}

	public static IEnumerator SetVolume(AudioSource source, float targetVolume, float fadeTime)
	{
		return null;
	}
}
