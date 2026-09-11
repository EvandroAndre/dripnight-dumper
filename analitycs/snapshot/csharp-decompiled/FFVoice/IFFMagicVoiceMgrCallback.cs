namespace FFVoice;

public interface IFFMagicVoiceMgrCallback
{
	void onEvent(FFMagicVoiceEvent evt, FFMagicVoiceErrorCode errorCode, string param);

	void onGetVipInfo(FFMagicVoiceErrorCode errorCode, FFMagicVoiceVipInfo vipInfo);
}
