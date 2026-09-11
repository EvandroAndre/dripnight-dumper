using GCommon.Audio;

namespace GCommon;

public abstract class AudioResourceManager : AudioSubSystem
{
	public abstract void SetAsyncLoad(bool enable, float maxDelay);

	public abstract void CancelAsyncLoading(uint playingID);
}
