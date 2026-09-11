using System.Collections.Generic;
using UnityEngine;

public class WeatherEffectController : MonoBehaviour
{
	public enum MainColor
	{
		blue,
		yellow,
		red
	}

	public List<GameObject> gameObjects;

	public List<Color> blueList;

	public List<Color> yellowList;

	public List<Color> redList;

	private MainColor m_MainColor;

	private static readonly int m_EffectMainColor;

	public static readonly int EffectAlpha;

	public void AddNullData()
	{
	}

	public void RemoveData(int index)
	{
	}

	public void TrySetMainColor(MainColor mainColor)
	{
	}

	public void TrySetAlpha(float ratio)
	{
	}

	public MainColor GetMainColor()
	{
		return MainColor.blue;
	}
}
