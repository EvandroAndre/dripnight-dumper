using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class EnergyStoneMarkScore : MonoBehaviour
{
	public UILabel ScoreLabel;

	public TweenPosition TweenPosition;

	public TweenAlpha TweenAlpha;

	private Vector3 m_DefaultToPos;

	public GameObject Arrow;

	public UIGrid Grid;

	private List<GameObject> m_ArrowList;

	private void Awake()
	{
	}

	public void ShowScore(string text, Vector3 startPos, byte scoreRegion)
	{
	}
}
