using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDUGC_ZombieLevelController : UIHUDUGC_InternalHudController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public int cur;

		public int identity;

		internal bool _003CSetCurrentLevel_003Eb__0(InfectionZombieGrowUpData x)
		{
			return false;
		}
	}

	private UIHUDUGC_ZombieLevelView m_View;

	private UGCZombieLevelHudRepItem m_ViewData;

	private List<UIHUDUGC_ZombieLevelItemController> m_ItemList;

	private bool m_LongPressed;

	private int m_SpeedUp;

	private int m_JumpUp;

	private List<InfectionZombieGrowUpData> m_DataList;

	private int levelOldValue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void SetTotalLevel(int cur)
	{
	}

	private void SetCurrentLevel(int cur)
	{
	}

	private void Update()
	{
	}

	private void _003COnUIInit_003Eb__8_0(bool press)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
