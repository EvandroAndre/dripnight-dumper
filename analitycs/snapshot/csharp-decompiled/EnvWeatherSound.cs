using System;

[Serializable]
public class EnvWeatherSound
{
	public bool hasSound;

	public float volume;

	public string loopOutside;

	public string loopInRoom;

	public string[] footsteps;

	public void CopyTo(EnvWeatherSound to)
	{
	}
}
