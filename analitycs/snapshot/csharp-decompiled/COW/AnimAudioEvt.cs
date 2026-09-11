using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW;

public class AnimAudioEvt : MonoBehaviour
{
	public enum ESuffixType
	{
		None,
		ADD_DEFAULT
	}

	private const string _DEFAULT = "_DEFAULT";

	public EAnimAudioBusType AudioBus;

	public ESuffixType AddSuffixWhenNotFound;

	public bool playAsync;

	private AudioPlaybackParams_Unity m_playbackParams;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PlaySound3D(AnimationEvent evt)
	{
	}

	private ResourceID GetResourceIDWithCurrentSuffix(string soundIDStr)
	{
		return default(ResourceID);
	}

	public void PlayAnimAudioBackGroundEvt(string soundIDStr)
	{
	}

	public void PlayAnimAudioLoopBackGroundEvt(string soundIDStr)
	{
	}

	public void PlayAnimOneShotWithoutStopShotEvt(string soundIDStr)
	{
	}

	public void PlayGachaFeatureAnimOneShotWithoutStopShotEvt()
	{
	}

	public void PlayAnimOneShotEvt(string soundIDStr)
	{
	}

	public void StopEvtShot()
	{
	}

	public void PlayAnimOnlyOneShotEvt(string soundIDStr)
	{
	}

	public void DispatchAnimEvent(string eventName)
	{
	}

	public void DispatchCharacterVoiceEvt(string soundID)
	{
	}
}
