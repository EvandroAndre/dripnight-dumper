using UnityEngine;

namespace GCommon.Audio.VolumeMonitor;

public class AudioVolumeMonitorUI : MonoBehaviour
{
	public UILabel m_VolumeAlertText;

	private AudioVolumeMonitor m_AudioVolumeMonitor;

	private void OnEnable()
	{
	}

	private void OnVolumeAlert(float volume, float volumeDb)
	{
	}

	private void OnVolumeAlertEnd()
	{
	}

	private void OnDisable()
	{
	}
}
