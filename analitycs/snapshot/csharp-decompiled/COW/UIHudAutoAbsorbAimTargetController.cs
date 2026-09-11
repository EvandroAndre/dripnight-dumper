using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAutoAbsorbAimTargetController : UIBaseController
{
	private UIHudAutoAbsorbAimTargetView m_View;

	private uint m_MaxDistance;

	private float m_MaxDistanceScale;

	private uint m_MinDistance;

	private UISprite[] m_TeammateSprite;

	private Color m_TeammateFullHPColor;

	private Color m_TeammateHPLoseColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowData(BHGGAEEHJCO playerId, Vector2 pos, float distance = 0f, uint min_distance = 0u, uint max_distance = 0u, float scale = 0f)
	{
	}

	private void ChangeTeammateSpriteColor(Color color)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
