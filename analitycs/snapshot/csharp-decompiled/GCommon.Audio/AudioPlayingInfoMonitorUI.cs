using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public class AudioPlayingInfoMonitorUI : MonoBehaviour
{
	public UILabel m_PlayingAudioInfoText;

	private AudioPlayingInfoMonitor m_AudioPlayingInfoMonitor;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateInfoText(Dictionary<int, PlayingAudioInfo> playingAudioInfoDict, float volumePCM)
	{
	}
}
