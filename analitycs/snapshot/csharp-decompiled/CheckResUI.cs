using System;
using UnityEngine;

public class CheckResUI : MonoBehaviour
{
	private Rect m_fps;

	private GUIStyle m_style;

	[NonSerialized]
	public int mode;

	public int m_currentIndex;

	public int m_allIndex;

	public int m_prefabCount;

	public int m_allUMACount;

	public int m_currentUMACount;

	public int m_currentClothID;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}
}
