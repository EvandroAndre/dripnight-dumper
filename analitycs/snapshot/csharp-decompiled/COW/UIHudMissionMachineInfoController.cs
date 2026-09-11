using GCommon;

namespace COW;

internal class UIHudMissionMachineInfoController : UIBaseController
{
	private UIHudMissionMachineInfoView m_View;

	private uint m_MachineID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint machineID, uint missionID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
