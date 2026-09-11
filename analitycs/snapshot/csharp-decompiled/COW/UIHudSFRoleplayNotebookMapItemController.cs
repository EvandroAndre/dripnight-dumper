using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSFRoleplayNotebookMapItemController : UIBaseController
{
	private UIHudSFRoleplayNotebookMapItemView m_View;

	private OPICPDCLKAG m_LevelObjectType;

	private uint m_LevelObjectID;

	private bool m_InCD;

	private float m_CDEndTime;

	private MutableString m_CountStr;

	private int m_CurrentCountDown;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	public void RefreshView()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
