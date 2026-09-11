namespace COW;

public enum EGameVoiceEvent
{
	None,
	InitOK,
	InitFailed,
	JoinOK,
	JoinFailed,
	Leaved,
	Resumed,
	Paused,
	Reconnecting,
	Reconnected,
	OthersMicOff,
	OthersMicOn,
	OthersSpeakerOff,
	OthersSpeakerOn,
	OthersVoiceOff,
	OthersVoiceOn,
	OwnMicOn,
	OwnMicOff,
	OwnVoiceOn,
	OwnVoiceOff,
	ListenOtherOn,
	ListenOtherOff,
	ReportAudio,
	MuteNotify,
	HasError
}
