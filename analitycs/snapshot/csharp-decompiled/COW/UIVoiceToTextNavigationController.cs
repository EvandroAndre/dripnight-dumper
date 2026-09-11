using System.Collections;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIVoiceToTextNavigationController : UIBaseNavigationController, IVoiceToText
{
	private VoiceToTextComponent m_VoiceToTextComponent;

	protected VoiceToTextComponent VoiceToText => null;

	protected void InitVoiceToText()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void RegisterVoiceToTextEvents()
	{
	}

	private void UnregisterVoiceToTextEvents()
	{
	}

	private void OnGameVoiceChannelPausedEvent(object[] data)
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	public abstract void OnVoiceRecordingStart();

	public abstract void OnVoiceRecordingProgress(float currentLength, float maxLength);

	public abstract void OnVoiceRecordingFinish();

	public abstract void OnVoiceTextResult(string recognizedText);

	public abstract void OnVoiceContentWarning(string recognizedText, string errorKey);

	public abstract void OnVoiceNoTextDetected(string errorKey);

	public abstract void OnVoiceError(VoiceToTextComponent.EVoiceToTextError error);

	Coroutine IVoiceToText.StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	void IVoiceToText.StopCoroutine(Coroutine routine)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
