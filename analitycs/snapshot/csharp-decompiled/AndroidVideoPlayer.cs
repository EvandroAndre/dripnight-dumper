using System;
using UnityEngine;
using UnityEngine.Video;

public class AndroidVideoPlayer : ICustomVideoPlayer
{
	private bool _003CisInit_003Ek__BackingField;

	private VideoState _003CvideoState_003Ek__BackingField;

	private VideoState mLastVideoState;

	private bool isSeekTo;

	private bool islooping;

	private int _handle;

	private bool isNeedApplicationResumePlaying;

	private Action _003ConVideoPrepare_003Ek__BackingField;

	private Action _003ConVideoStart_003Ek__BackingField;

	private Action _003ConVideoEnd_003Ek__BackingField;

	private Action _003ConVideoSeek_003Ek__BackingField;

	private float last_time;

	private uint iDelayKey;

	private readonly float ENDTIME;

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

	public Texture GetTexture()
	{
		return null;
	}

	private void OnInit()
	{
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

	private void AddCallback()
	{
	}

	private void RemoveCallback()
	{
	}

	private void OnVideoStart()
	{
	}

	private void OnVideoEnd()
	{
	}

	private void OnVideoPrepareCompleted()
	{
	}

	private void OnVideoSeekCompleted()
	{
	}

	private void OnVideoPause()
	{
	}

	public void OnApplicationPause(bool pause)
	{
	}

	private void _003COnVideoSeekCompleted_003Eb__54_0()
	{
	}
}
