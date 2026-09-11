using System;

[Serializable]
public class EnvWeatherEffect
{
	public string effectResourceID;

	public float effectUp;

	public float effectDistance;

	public bool stopWhenUnderShelter;

	public bool useOriginPosAndRot;

	public bool lerpAlphaWithRatio;

	public bool saveEffectSetColor;

	public WeatherEffectController.MainColor saveEffectSetColorType;

	public void CopyTo(EnvWeatherEffect to)
	{
	}
}
