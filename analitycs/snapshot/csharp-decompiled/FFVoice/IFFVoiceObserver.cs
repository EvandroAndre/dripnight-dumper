namespace FFVoice;

public interface IFFVoiceObserver
{
	void OnEvent(int event_id, int errorCode, string channelID, string param);

	void OnMemberChange(string strParam);

	bool GetEnableGameVoiceEngineCallbackMessageV2();
}
