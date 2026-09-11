using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Video;

public class CustomVideoPlayer
{
	private enum ActionType
	{
		Prepare = 9413,
		Play,
		Pause,
		Update,
		Destroy,
		ClearException
	}

	private enum CallbackType
	{
		PrepareCB = 9413,
		PlayCB,
		PauseCB,
		SeekToCB
	}

	public delegate void PrepareCallbackSta();

	public delegate void PlayCallbackSta();

	public delegate void PauseCallbackSta();

	public delegate void SeekToCallbackSta();

	private class InstanceData
	{
		public bool isInit;

		public bool isAction;

		public Texture2D outTexture;

		public List<uint> callbackList;

		public PrepareCallbackSta prepareCallback;

		public PlayCallbackSta playCallback;

		public PauseCallbackSta pauseCallback;

		public SeekToCallbackSta seekToCallback;
	}

	private delegate void CallbackCoreSta(int handle, uint callbackType);

	private static int s_NextHandle;

	private static Dictionary<int, InstanceData> s_Instances;

	private static Mutex s_Mutex;

	private static bool s_NativeCallbackInited;

	private static CallbackCoreSta s_CallbackCoreDelegate;

	[PreserveSig]
	private static extern int CV_MakeEventID(int handle, int action);

	[PreserveSig]
	private static extern void CV_SetVideoClip(int handle, string path, ulong offset, ulong size, float volume);

	[PreserveSig]
	private static extern void CV_SetVideoClipWithURL(int handle, string path, float volume);

	[PreserveSig]
	private static extern void CV_SetOutTexture(int handle, IntPtr id, int width, int height);

	[PreserveSig]
	private static extern void CV_SetTime(int handle, int time);

	[PreserveSig]
	private static extern void CV_SetLooping(int handle, bool isLooping);

	[PreserveSig]
	private static extern void CV_SetCallbackCore(int handle, IntPtr callbackPtr);

	[PreserveSig]
	private static extern int CV_GetTime(int handle);

	[PreserveSig]
	private static extern int CV_GetDuration(int handle);

	[PreserveSig]
	private static extern bool CV_IsLooping(int handle);

	[PreserveSig]
	private static extern bool CV_IsPlaying(int handle);

	private static void CallbackCoreDef(int handle, uint callbackType)
	{
	}

	private static void EnsureNativeCallback()
	{
	}

	private static InstanceData GetOrCreate(int handle)
	{
		return null;
	}

	public static int AllocHandle()
	{
		return 0;
	}

	public static Texture2D GetTexture(int handle)
	{
		return null;
	}

	public static void SetTime(int handle, int time)
	{
	}

	public static void SetLooping(int handle, bool isLooping)
	{
	}

	public static int GetTime(int handle)
	{
		return 0;
	}

	public static int GetDuration(int handle)
	{
		return 0;
	}

	public static bool IsLooping(int handle)
	{
		return false;
	}

	public static bool IsPlaying(int handle)
	{
		return false;
	}

	private static void OnInit(int handle)
	{
	}

	private static void InitOutTexture(int handle, int width, int height)
	{
	}

	public static void SetPrepareCallback(int handle, PrepareCallbackSta cb)
	{
	}

	public static void SetPlayCallback(int handle, PlayCallbackSta cb)
	{
	}

	public static void SetPauseCallback(int handle, PauseCallbackSta cb)
	{
	}

	public static void SetSeekToCallback(int handle, SeekToCallbackSta cb)
	{
	}

	public static void Prepare(int handle, VideoClip clip, float volume)
	{
	}

	public static void PrepareWithURL(int handle, string path, int width, int height, float volume)
	{
	}

	public static void Play(int handle)
	{
	}

	public static void Pause(int handle)
	{
	}

	public static void Update(int handle)
	{
	}

	public static void Destroy(int handle)
	{
	}

	public static void ClearException(int handle)
	{
	}
}
