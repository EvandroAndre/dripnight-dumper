using System;
using UnityEngine;
using UnityEngine.Video;

public class UnityVideoPlayer : ICustomVideoPlayer
{
	private VideoPlayer videoPlayer;

	private RenderTexture mRT;

	private bool _003CisInit_003Ek__BackingField;

	private bool islooping;

	private Action _003ConVideoPrepare_003Ek__BackingField;

	private Action _003ConVideoStart_003Ek__BackingField;

	private Action _003ConVideoEnd_003Ek__BackingField;

	private Action _003ConVideoSeek_003Ek__BackingField;

	private VideoState _003CvideoState_003Ek__BackingField;

	private VideoState mLastVideoState;

	private bool isSeekTo;

	private GameObject gameObject;

	private uint iDelayKey;

	public bool isInit
	{
		get
		{
			return _003CisInit_003Ek__BackingField;
		}
		private set
		{
			_003CisInit_003Ek__BackingField = value;
		}
	}

	public bool isLooping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float time => 0f;

	public float length => 0f;

	public Action onVideoPrepare
	{
		get
		{
			return _003ConVideoPrepare_003Ek__BackingField;
		}
		set
		{
			_003ConVideoPrepare_003Ek__BackingField = value;
		}
	}

	public Action onVideoStart
	{
		get
		{
			return _003ConVideoStart_003Ek__BackingField;
		}
		set
		{
			_003ConVideoStart_003Ek__BackingField = value;
		}
	}

	public Action onVideoEnd
	{
		get
		{
			return _003ConVideoEnd_003Ek__BackingField;
		}
		set
		{
			_003ConVideoEnd_003Ek__BackingField = value;
		}
	}

	public Action onVideoSeek
	{
		get
		{
			return _003ConVideoSeek_003Ek__BackingField;
		}
		set
		{
			_003ConVideoSeek_003Ek__BackingField = value;
		}
	}

	public VideoState videoState
	{
		get
		{
			return _003CvideoState_003Ek__BackingField;
		}
		private set
		{
			_003CvideoState_003Ek__BackingField = value;
		}
	}

	public UnityVideoPlayer(GameObject go)
	{
	}

	private void Oninit()
	{
	}

	public Texture GetTexture()
	{
		return null;
	}

	public void Prepare(VideoClip clip, float volume = 100f, bool islooping = false)
	{
	}

	public void Prepare(string path, int width, int height, float volume = 100f, bool islooping = false)
	{
	}

	public void Destroy()
	{
	}

	public bool Play()
	{
		return false;
	}

	public bool Pause()
	{
		return false;
	}

	public bool PrepareSeekTo()
	{
		return false;
	}

	public bool SeekTo(float time)
	{
		return false;
	}

	public void Update()
	{
	}

	private void OnVideoStart(VideoPlayer source)
	{
	}

	private void OnVideoEnd(VideoPlayer source)
	{
	}

	private void OnVideoPrepareCompleted(VideoPlayer source)
	{
	}

	private void OnVideoSeekCompleted(VideoPlayer source)
	{
	}

	private void OnErrorReceived(VideoPlayer source, string message)
	{
	}

	public void OnApplicationPause(bool pause)
	{
	}

	private void _003COnVideoSeekCompleted_003Eb__52_0()
	{
	}
}
