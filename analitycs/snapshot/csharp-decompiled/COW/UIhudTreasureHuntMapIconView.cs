using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIhudTreasureHuntMapIconView : MonoBehaviour
{
	public UISprite Icon;

	private ETreasureHuntMapIconState m_State;

	private OPICPDCLKAG m_LevelObjectType;

	private uint m_LevelObjectID;

	private ResourceID m_UIFXResID;

	private VisualInstanceHolder m_UIFXHolder;

	public ETreasureHuntMapIconState State
	{
		get
		{
			return ETreasureHuntMapIconState.None;
		}
		set
		{
		}
	}

	public void RefreshView(ETreasureHuntMapIconState state, ResourceID uifxResID)
	{
	}

	private uint GetIconResIDByState(ETreasureHuntMapIconState state)
	{
		return 0u;
	}

	public void ShowUIFX()
	{
	}

	public void OnDestroy()
	{
	}

	public void InitLevelObjectInfo(OPICPDCLKAG levelObjectType, uint levelObjectID)
	{
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	public OPICPDCLKAG GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}
}
