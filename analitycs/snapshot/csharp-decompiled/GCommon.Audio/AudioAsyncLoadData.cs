using UnityEngine;

namespace GCommon.Audio;

public abstract class AudioAsyncLoadData
{
	public uint Ticket;

	public uint PlayingID;

	public ResourceID Sound;

	public GameObject Emitter;

	public Vector3 WorldPos;

	public float StartLoadTime;

	public PlayOnAudioAsyncLoaded PlayFunction;

	public AudioManager.AudioEndCallBack EndCallback;

	public virtual void Reset()
	{
	}
}
