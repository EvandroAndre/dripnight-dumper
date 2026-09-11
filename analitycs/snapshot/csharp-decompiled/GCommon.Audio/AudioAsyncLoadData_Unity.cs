using System;
using UnityEngine;

namespace GCommon.Audio;

public class AudioAsyncLoadData_Unity : AudioAsyncLoadData
{
	public readonly AudioPlaybackParams_Unity PlaybackParams;

	public bool Is3D;

	public ResourceManager.LoadPriority Priority;

	public Action<GameObject> EmitterCallback;

	public AudioClip Clip;

	public AudioGroup Group;

	public bool IsVirtualized;

	public override void Reset()
	{
	}
}
