using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace COW;

public class AudioCDNDownload : MonoBehaviour
{
	private sealed class _003CDownloadAndPlayFile_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioCDNDownload _003C_003E4__this;

		public string filePath;

		public uint id;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownloadAndPlayFile_003Ed__8(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CPlayAudioFileCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public AudioCDNDownload _003C_003E4__this;

		public uint id;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAudioFileCoroutine_003Ed__6(int _003C_003E1__state)
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

	private sealed class _003CPlayFromLocalFile_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string filePath;

		public AudioCDNDownload _003C_003E4__this;

		public uint id;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayFromLocalFile_003Ed__7(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private string m_CDNAddr;

	public string m_DestCDNURL;

	public AudioType m_AudioType;

	private Action<bool, uint, AudioClip> m_OnDownloadCallback;

	private void Awake()
	{
	}

	public void PlayAudioFile(string url, uint id, Action<bool, uint, AudioClip> onDownloadCallback, AudioType audioType = AudioType.MPEG)
	{
	}

	private IEnumerator PlayAudioFileCoroutine(string url, uint id)
	{
		return null;
	}

	private IEnumerator PlayFromLocalFile(string filePath, uint id)
	{
		return null;
	}

	private IEnumerator DownloadAndPlayFile(string filePath, uint id)
	{
		return null;
	}

	private void OnDownloadRes(bool success, uint id, AudioClip clip)
	{
	}

	public void Reset()
	{
	}
}
