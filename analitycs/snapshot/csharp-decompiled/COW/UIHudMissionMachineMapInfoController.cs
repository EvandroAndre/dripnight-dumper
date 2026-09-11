using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudMissionMachineMapInfoController : UIBaseController
{
	private uint m_ID;

	private BCPDKCCIAGN m_Type;

	private UIHudMissionMachineMapInfoView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint machineID, BCPDKCCIAGN type)
	{
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	private void OnHippoCrisisMissionStart(GEvent data)
	{
	}

	private void OnHippoCrisisMissionEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
