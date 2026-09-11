using System;
using UnityEngine;
using UnityEngine.Video;

public interface ICustomVideoPlayer
{
	bool isInit { get; }

	bool isLooping { get; set; }

	float time { get; }

	float length { get; }

	VideoState videoState { get; }

	Action onVideoPrepare { get; set; }

	Action onVideoStart { get; set; }

	Action onVideoEnd { get; set; }

	Action onVideoSeek { get; set; }

	void Prepare(VideoClip clip, float volume = 100f, bool islooping = false);

	void Prepare(string path, int width, int height, float volume = 100f, bool islooping = false);

	bool Play();

	bool Pause();

	void Destroy();

	void Update();

	bool PrepareSeekTo();

	bool SeekTo(float time);

	Texture GetTexture();

	void OnApplicationPause(bool pause);
}
