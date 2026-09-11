using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudIIVGPCursedEnergyMainController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public uint id;

		internal bool _003COnSkillUnlock_003Eb__0(uint value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public uint id;

		public UIHudIIVGPCursedEnergyMainItem item;

		public UIHudIIVGPCursedEnergyMainController _003C_003E4__this;

		internal void _003CRefreshUI_003Eb__0()
		{
		}

		internal void _003CRefreshUI_003Eb__1()
		{
		}

		internal void _003CRefreshUI_003Eb__2()
		{
		}

		internal void _003CRefreshUI_003Eb__3()
		{
		}
	}

	public const uint VISIBILITY_STATE_Hide_All = 1073741824u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 536870912u;

	private List<UIHudIIVGPCursedEnergyMainItem> m_Items;

	private UIHudIIVGPCursedEnergyMainView m_View;

	private OOJDNBLCKKC m_Module;

	private bool m_InitFinish;

	private List<uint> m_SkillIds;

	private VisualInstanceHolder m_UnlockHolder;

	private bool m_HasNewSelectSkill;

	private uint m_HudEffect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSkillUnlock(uint id)
	{
	}

	private void OnItemLevelUpClick(uint id)
	{
	}

	private void OnItemUnlockClick(uint id)
	{
	}

	private void OnSelectClick(uint id)
	{
	}

	private void OnItemDetailClick(uint id, Vector3 btnPos)
	{
	}

	private void HideItemDetail()
	{
	}

	private void OnShowIIVGPMain(bool show)
	{
	}

	private void OnBtnBgClick()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnCursedEnergyNumChange(uint oldValue, uint newValue)
	{
	}

	private void OnSkillChange()
	{
	}

	private void OnEquipChange(GEvent data)
	{
	}

	private void OnCurSelectSkillChange(uint skill)
	{
	}

	private void OnCostChange()
	{
	}

	private void RefreshUI()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void OnPlayerBeHit(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
