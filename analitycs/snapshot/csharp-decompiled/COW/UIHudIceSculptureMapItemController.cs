using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudIceSculptureMapItemController : UIBaseController
{
	private UIHudIceSculptureMapItemView m_View;

	private uint m_LevelObjectId;

	private OPICPDCLKAG m_LevelObjectType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(ModifiableObjectsConfig configData, uint levelObjectId, BDNDCIPKGEC iceSculptureType)
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	public OPICPDCLKAG GetLevelOnjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
