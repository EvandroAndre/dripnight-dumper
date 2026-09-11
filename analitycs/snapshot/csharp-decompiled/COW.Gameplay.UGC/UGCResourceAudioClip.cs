using System;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCResourceAudioClip : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public AudioEngine_Unity unityAudioEngine;

		public float volume;

		public float speed;

		public Action<GameObject> callback;

		internal void _003CPlayOneShot_003Eb__0(bool succ, UGCResourceAudioClip resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public AudioSource audioSource;

		public Action<GameObject> callback;

		public GameObject objUsePlayer;

		internal void _003CPlay3DLoopStart_003Eb__0(bool _, UGCResourceAudioClip resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public string ffResNameOrUUID;

		public AudioResource audioRes;

		public AudioEngine_Unity unityAudioEngine;

		public Action<AudioResource> callback;

		internal void _003CPlay2DLoopStart_003Eb__0(bool succ, UGCResourceAudioClip resObj)
		{
		}
	}

	private bool m_isCustomAudioClip;

	private AudioClip m_unityAudioClip;

	private byte[] m_cacheData;

	public AudioClip Clip => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, UnityEngine.Object resObject)
	{
	}

	public override void ReleaseUnityResRef()
	{
	}

	public static void Play3DLoopStart(string ffResNameOrUUID, Transform parent, ResourceID audioSourceID, Action<GameObject> callback, float volume = 1f, float distance = -1f)
	{
	}

	public static void Play2DLoopStart(string ffResNameOrUUID, Action<AudioResource> callback, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, int inGameGroup = -1)
	{
	}

	public static void PlayOneShot(string ffResNameOrUUID, float volume = 1f, float speed = 1f, Action<GameObject> callback = null)
	{
	}

	public static void StopPlayShot(GameObject go)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, UnityEngine.Object P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ReleaseUnityResRef()
	{
	}
}
