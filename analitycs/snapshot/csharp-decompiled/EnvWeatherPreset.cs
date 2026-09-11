using UnityEngine;

public class EnvWeatherPreset : ScriptableObject
{
	public EnvSkybox skybox;

	public EnvGlobalSetting setting;

	public EnvWeatherEffect effect;

	public EnvWeatherSound sound;

	public EnvWeatherPreset Clone()
	{
		return null;
	}

	public void CopyTo(EnvWeatherPreset to)
	{
	}
}
