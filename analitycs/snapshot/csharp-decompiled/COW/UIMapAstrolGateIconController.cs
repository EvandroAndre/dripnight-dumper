using GCommon;
using UnityEngine;

namespace COW;

public class UIMapAstrolGateIconController : UIBaseController
{
	private UIMapAstrolGateIconView m_View;

	private bool m_IsSelected;

	private uint m_AstrolGateID;

	private Vector3 m_WorldPosition;

	public uint AstrolGateID => 0u;

	public Vector3 WorldPosition => default(Vector3);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint astrolGateID, Vector3 worldPosition)
	{
	}

	public void SetSelectedState(bool isSelected)
	{
	}

	private void UpdateIcon()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
