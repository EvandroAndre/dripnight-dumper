using GCommon;

namespace COW;

public class UIHudVoiceToTextController : UIVoiceToTextBaseController
{
	public const int WIDGET_WIDTH = 400;

	public const int WIDGET_HEIGHT = 200;

	private UIHudVoiceToTextView m_View;

	private UIModelChat m_ModelChat;

	private string m_RecognizedText;

	private EVoiceToTextUIState m_UIState;

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

	private void OnLocalPlayerBeHit(object[] data)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnSendBtnClick()
	{
	}

	private void TrySendMsgToSocialChannel(string msg)
	{
	}

	private void StartMsgCDCheck()
	{
	}

	private void StartTextChatCDCheck()
	{
	}

	private void OnRerecordBtnClick()
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
