using GCommon;
using UnityEngine;

namespace COW;

public class UIHud2NBGPMapContentBloodMoonAirdropIconController : UIBaseController
{
	private uint m_LevelObjectID;

	private UIHud2NBGPMapContentBloodMoonAirdropIconView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint airdropObjectID, Vector3 iconPosition, Quaternion iconRotation, Vector3 iconScale)
	{
	}

	public void UpdateIconRotation(Quaternion iconRotation)
	{
	}

	public void UpdateIconScale(Vector3 iconScale)
	{
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	public Transform GetRootTransform()
	{
		return null;
	}

	public Bounds GetTapDetectBounds()
	{
		return default(Bounds);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
