using System.Collections.Generic;
using UnityEngine;

public class LobbyWeatherEffectController : MonoBehaviour
{
	public enum MainColor
	{
		blue,
		yellow,
		red
	}

	public List<GameObject> GameObjects;

	public List<Color> CurrentMainColor;

	public Dictionary<Renderer, Color> m_ColorRecord;

	private bool m_RecordedColor;

	private MaterialPropertyBlock m_MaterialPropertyBlock;

	private MainColor m_MainColor;

	private static readonly int m_EffectMainColor;

	private void Awake()
	{
	}

	public void TrySetMainColor(MainColor mainColor)
	{
	}

	public MainColor GetMainColor()
	{
		return MainColor.blue;
	}

	public void TrySetProprtyColor(MaterialPropertyBlock mpb)
	{
	}
}
