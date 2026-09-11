using System.Collections;
using UnityEngine;

namespace COW;

public interface IVoiceToText
{
	void OnVoiceRecordingStart();

	void OnVoiceRecordingProgress(float currentLength, float maxLength);

	void OnVoiceRecordingFinish();

	void OnVoiceTextResult(string recognizedText);

	void OnVoiceContentWarning(string recognizedText, string errorKey);

	void OnVoiceNoTextDetected(string errorKey);

	void OnVoiceError(VoiceToTextComponent.EVoiceToTextError error);

	Coroutine StartCoroutine(IEnumerator routine);

	void StopCoroutine(Coroutine routine);
}
