using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public class AudioResourceManager_Unity : AudioResourceManager, IReusableObjectOwner
{
	private ResourceRefCache m_AudioClipCache;

	private readonly Dictionary<GameObject, ObjectPool<AudioResource>> m_AudioResourcePool;

	private GameObject m_OwnedObject;

	private readonly Dictionary<int, GameObject> m_OneShotPool;

	private readonly Dictionary<int, Action> m_CallBackPool;

	private const int ForcePositive = int.MaxValue;

	private float m_AsyncLoadMaxDelay;

	public bool EnableAutoAsyncLoad;

	private readonly SortedDictionary<uint, AudioAsyncLoadData_Unity> m_AsyncLoadingData;

	private readonly Dictionary<uint, uint> m_PlayingIDTicketMap;

	private readonly List<uint> m_AsyncLoadingToRemove;

	private readonly Stack<AudioAsyncLoadData_Unity> m_PooledAsyncLoadingData;

	private Action<uint, bool, UnityEngine.Object> m_OnAudioAsyncLoaded;

	private ResourceRefCache m_MultiSoundCache;

	public override void OnInit()
	{
	}

	public override void RunOneFrame(float deltaTime)
	{
	}

	public override void OnGameDestroy()
	{
	}

	public override void OnCleanUp()
	{
	}

	public void RecycleReusableObject(int ticket)
	{
	}

	public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
	{
	}

	public void BindOnwer(GameObject owner)
	{
	}

	public AudioResource AllocAudioResource(ResourceID sound, GameObject emitter = null, bool loadClip = true)
	{
		return null;
	}

	public int AllocAudioObject(ResourceID sound, float volume, out AudioSource audio, out ReusableObject reusableObject, Action endCallback = null)
	{
		audio = null;
		reusableObject = null;
		return 0;
	}

	public GameObject GetPresetPrefab(ResourceID resourceID)
	{
		return null;
	}

	public void RecyclePresetPrefab(ResourceID resourceID, GameObject prefab)
	{
	}

	public void CollectAudioResource(AudioResource res, GameObject emitter = null)
	{
	}

	public void CollectAudioObject(int ticket)
	{
	}

	public bool IsOneShotPlaying(int ticket)
	{
		return false;
	}

	public AudioClip LoadAudioClip(ResourceID sound)
	{
		return null;
	}

	public bool IsAudioLoaded(ResourceID sound)
	{
		return false;
	}

	public void UnloadAllAudio()
	{
	}

	public void UnloadAudio(ResourceID sound)
	{
	}

	public void UnloadAudiosByABPath(string abPath)
	{
	}

	private void ClearAudioClip(ResourceID soundID, UnityEngine.Object obj)
	{
	}

	public override void SetAsyncLoad(bool enable, float maxDelay)
	{
	}

	private void PoolReturnAsyncLoadingData(AudioAsyncLoadData_Unity data)
	{
	}

	public AudioAsyncLoadData PoolGetAsyncLoadData()
	{
		return null;
	}

	public uint LoadAudioClipAsync(AudioAsyncLoadData_Unity data)
	{
		return 0u;
	}

	private void OnAudioClipAsyncLoaded(uint ticket, bool ok, UnityEngine.Object obj)
	{
	}

	private void PlayAsyncLoadedSound(AudioAsyncLoadData_Unity data)
	{
	}

	private void CheckAsyncLoadingTimeOut()
	{
	}

	private void CancelAllAsyncLoadings()
	{
	}

	public override void CancelAsyncLoading(uint playingID)
	{
	}

	private void CancelAsyncLoading(AudioAsyncLoadData_Unity data)
	{
	}

	internal MultiSound LoadMultiSound(ResourceID soundID)
	{
		return null;
	}
}
