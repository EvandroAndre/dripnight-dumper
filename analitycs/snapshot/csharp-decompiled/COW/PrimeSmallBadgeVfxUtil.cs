using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class PrimeSmallBadgeVfxUtil : MonoBehaviour
{
	public UISprite m_PrimeBadgeSprite;

	private GameObject m_VFX;

	private Dictionary<ResourceID, GameObject> m_VFXDict;

	private uint m_DefaultBadgeWidth;

	private void Awake()
	{
	}

	public void ShowPrimeBadgeVfx(ResourceID iconVfxRes)
	{
	}

	public void HideVfx()
	{
	}
}
