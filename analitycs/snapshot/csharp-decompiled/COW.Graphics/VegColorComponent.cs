using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class VegColorComponent : MonoBehaviour
{
	public List<VegColorRatio> m_vegColorRatioList;

	public bool m_randomScaleSize;

	public bool m_hasReplacement;

	public List<VegColorRatio> m_vegColorRatioListReplace;

	private void Awake()
	{
	}

	public void ApplyOverrideByMode()
	{
	}
}
