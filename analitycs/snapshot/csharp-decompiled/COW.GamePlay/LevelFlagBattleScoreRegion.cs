using UnityEngine;

namespace COW.GamePlay;

public class LevelFlagBattleScoreRegion : BaseLevelObject
{
	public float m_Width;

	public float m_Length;

	public int m_Region;

	public Color m_Color;

	protected override string GetObjectTag()
	{
		return null;
	}
}
