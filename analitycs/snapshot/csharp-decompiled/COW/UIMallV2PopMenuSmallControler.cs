using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2PopMenuSmallControler : UIPopMenuSmallControler
{
	private bool _003CIsFirstSubMenuSelectAll_003Ek__BackingField;

	private PopMenuData m_ParentMenuData;

	public bool IsFirstSubMenuSelectAll
	{
		get
		{
			return _003CIsFirstSubMenuSelectAll_003Ek__BackingField;
		}
		set
		{
			_003CIsFirstSubMenuSelectAll_003Ek__BackingField = value;
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void ResetColliderSize(Vector3 size)
	{
	}

	public override void OnParentSelect(object obj)
	{
	}

	public override void OnClickeMenuItem(PopMenuData data)
	{
	}

	public override void SetCurrentSelectData(PopMenuData data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnParentSelect(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickeMenuItem(PopMenuData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetCurrentSelectData(PopMenuData P0)
	{
	}
}
