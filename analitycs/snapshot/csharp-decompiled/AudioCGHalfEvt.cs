using System;
using System.Collections.Generic;
using COW;

public class AudioCGHalfEvt : AnimAudioEvt
{
	public enum e_PlayStep
	{
		start,
		end
	}

	public enum e_AudioCGHalfFunc
	{
		PlayAnimAudioBackGroundEvt,
		PlayAnimAudioLoopBackGroundEvt,
		PlayAnimOneShotEvt,
		StopEvtShot,
		PlayAnimOnlyOneShotEvt,
		ResumeAudioVolume,
		ReduceAudioVolume,
		DispatchAnimEvent
	}

	[Serializable]
	public class AudioCGHalfEvtData
	{
		public e_PlayStep E_PlayStep;

		public e_AudioCGHalfFunc E_AudioFunc;

		public float FloatParam;

		public string StrParam;
	}

	private List<AudioCGHalfEvtData> m_eventDatas;

	private bool m_IsMusicDucked;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void ResumeMusicVolume()
	{
	}

	public void ReduceAudioVolume(float volumeRate)
	{
	}

	private void ToDoFunc(AudioCGHalfEvtData data)
	{
	}
}
