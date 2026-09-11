using UnityEngine;

public class WeatherRelatedGameObject : MonoBehaviour
{
	public string[] WeatherNames;

	public bool[] ShowOrNot;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnWeatherChanged(string weatherName)
	{
	}
}
