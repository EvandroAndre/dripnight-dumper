using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIHippoCrisisLobbyTeamInfoItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIHippoCrisisLobbyTeamEquipInfoController equipInfoItem;

		internal bool _003CSetViewData_003Eb__0(HippoInventoryEquipItem item)
		{
			return false;
		}
	}

	public static readonly uint WEAPONCNT;

	public static readonly uint ARMORCNT;

	public static readonly uint OTHERCNT;

	private UIHippoCrisisLobbyTeamInfoItemView m_View;

	private uint m_Value;

	private List<UIHippoCrisisLobbyTeamEquipInfoController> m_EquipInfoItems;

	private UIModelHippoCrisis m_ModelHippoCrisis;

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

	public uint GetValue()
	{
		return 0u;
	}

	public void SetViewData(GroupMemberInfo member)
	{
	}

	public void RefreshSelfEquipView()
	{
	}

	private void InitEmptyView()
	{
	}

	private int GetShowIndexBySlot(EHippoCrisisEquipmentSlot slot)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
