using UnityEngine;

public class WeatherMaterialOverride : MonoBehaviour
{
	private Renderer cachedRenderer;

	public string weatherName;

	public Color[] colors;

	public string[] colorNames;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWeatherChanged(string weatherName)
	{
	}

	public void ReadProperties()
	{
	}

	public void ApplyProperties()
	{
	}
}
