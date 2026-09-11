namespace GCommon.Audio;

public abstract class AudioSubSystem
{
	public abstract void OnInit();

	public abstract void RunOneFrame(float deltaTime);

	public abstract void OnGameDestroy();

	public abstract void OnCleanUp();
}
