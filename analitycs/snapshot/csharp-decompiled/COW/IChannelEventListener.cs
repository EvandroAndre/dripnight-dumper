namespace COW;

public interface IChannelEventListener
{
	void OnMemberEvent(MemberEvent memberEvent);

	void OnKickOff(BaseResult error);

	void OnStartReconnect();

	void OnReconnectResult(ReconnectResult result);

	void OnSpeakingStateChanged(bool isSpeaking);

	void OnChannelError(BaseResult error);

	void OnChannelPauseResult(BaseResult result);

	void OnChannelResumeResult(BaseResult result);
}
