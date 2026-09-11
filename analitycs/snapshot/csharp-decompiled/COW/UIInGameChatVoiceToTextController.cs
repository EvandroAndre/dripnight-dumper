using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameChatVoiceToTextController : UIVoiceToTextBaseController
{
	public const int WIDGET_WIDTH = 400;

	public const int WIDGET_HEIGHT = 200;

	public static readonly Color TIME_NOT_ENOUGH_COLOR;

	public static readonly Color TIME_NORMAL_COLOR;

	private UIInGameChatVoiceToTextView m_View;

	private UIModelChat m_ModelChat;

	private string m_RecognizedText;

	private Action<string> m_OnRecognizedText;

	private EVoiceToTextUIState m_UIState;

	public void SetOnRecognizedText(Action<string> onRecognizedText)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void SetUIState(EVoiceToTextUIState state, string errorKey = "")
	{
	}

	private void ConfigureVoiceToText()
	{
	}

	private void StartRecording()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnFinishRecordBtnClick()
	{
	}

	public override void OnVoiceRecordingStart()
	{
	}

	public override void OnVoiceRecordingProgress(float progress, float totalTime)
	{
	}

	public override void OnVoiceRecordingFinish()
	{
	}

	public override void OnVoiceTextResult(string recognizedText)
	{
	}

	public override void OnVoiceContentWarning(string recognizedText, string errorKey)
	{
	}

	public override void OnVoiceNoTextDetected(string errorKey)
	{
	}

	public override void OnVoiceError(VoiceToTextComponent.EVoiceToTextError error)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
