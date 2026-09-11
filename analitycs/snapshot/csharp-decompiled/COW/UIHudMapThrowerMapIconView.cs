using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIHudMapThrowerMapIconView : MonoBehaviour
{
	public UISprite Icon;

	public Animation Anim;

	public ulong UniqueID;

	private uint m_ItemId;

	private uint m_LevelObjectId;

	private OPICPDCLKAG m_LevelObjectType;

	public uint ItemId => 0u;

	public uint LevelObjectId => 0u;

	public OPICPDCLKAG LevelObjectType => OPICPDCLKAG.Invalid;

	public void SetData(uint itemId, ulong uniqueID, uint levelObjectId, OPICPDCLKAG levelObjectType)
	{
	}

	public void ShowMapIcon(bool isShow)
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}
}
