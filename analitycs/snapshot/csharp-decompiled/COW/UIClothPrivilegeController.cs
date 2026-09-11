using GCommon;
using UnityEngine;

namespace COW;

internal class UIClothPrivilegeController : UIBaseController
{
	private UIClothPrivilegeItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(TeamClothPrivilegeDetail privilege)
	{
	}

	public void SetData(CollectionPrivilegeTagData privilege)
	{
	}

	public void SetData(ResourceID icon, string desc)
	{
	}

	public void SetDataWithParams(ResourceID icon, string desc, uint param, uint param2)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public Vector2 GetMaxMinY()
	{
		return default(Vector2);
	}

	public Vector3[] GetLabelCornerWorldPos()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
