using System;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

public class FFVideoPlayer : MonoBehaviour
{
	private ICustomVideoPlayer videoPlayer;

	private UITexture rawImage;

	private bool m_IsAndroidVideoPlayer;

	private CustomVideoPlayerUpdate customplayerupdate;

	public Action onVideoPrepare;

	public Action onVideoStart;

	public Action onVideoEnd;

	public Action onVideoSeekTo;

	public VideoState videoState => VideoState.IDLE;

	public float time => 0f;

	public int length => 0;

	private void init()
	{
	}

	private void InitVideoPlayer(bool useUnityVideoPlayer = false)
	{
	}

	public void InitUnityVideoPLayer()
	{
	}

	public void PrepareWithoutDestory(VideoClip clip, float volume = 100f, bool islooping = false, bool useUnityVideoPlayer = false)
	{
	}

	public void Prepare(string path, int width, int height, float volume = 100f, bool islooping = false, bool userUnityVideoPlayer = false)
	{
	}

	public Vector2 GetTextureSize()
	{
		return default(Vector2);
	}

	public void DestroyPlay()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
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

	private void OnApplicationPause(bool pause)
	{
	}
}
