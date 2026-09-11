using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudWeaponPropertyListHelper
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIHudWeaponPropertyListHelper _003C_003E4__this;

		public uint refreshVersion;

		public AGACNOCEEFP weaponData;
	}

	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public int propertyIndex;

		public EWeaponScoreID scoreId;

		public string propertyName;

		public _003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals1;

		internal void _003CRefreshWeaponPropertyList_003Eb__0(uint ticket, bool success, UnityEngine.Object obj)
		{
		}
	}

	private readonly uint[] m_ScoreIds;

	private readonly ResourceID m_PropertyItemResId;

	private readonly Transform m_PropertyItemParent;

	private readonly Action m_OnLayoutChanged;

	private readonly List<UIHudWeaponPropertyItemView> m_PropertyItemCtrls;

	private readonly List<uint> m_PropertyItemTicketIds;

	private uint m_RefreshVersion;

	private AGACNOCEEFP m_CurrentWeaponData;

	private bool m_ShowBeforeReinforced;

	private bool m_IsReinforced;

	private bool m_SuppressLayoutNotify;

	private int m_PendingCreateCount;

	public UIHudWeaponPropertyListHelper(ResourceID propertyItemResId, Transform propertyItemParent, Action onLayoutChanged)
	{
	}

	public void RefreshWeaponPropertyList(AGACNOCEEFP weaponData)
	{
	}

	public void RefreshWeaponPropertyList(AGACNOCEEFP weaponData, bool showBeforeReinforced, bool isReinforced)
	{
	}

	private void OnCreateResolved()
	{
	}

	private void NotifyLayoutChanged()
	{
	}

	private void EnsurePropertyItemCount()
	{
	}

	private string GetPropertyName(EWeaponScoreID scoreId)
	{
		return null;
	}

	private void RefreshSinglePropertyItem(UIHudWeaponPropertyItemView ctrl, AGACNOCEEFP weaponData, EWeaponScoreID scoreId, string propertyName)
	{
	}

	public void ClearWeaponPropertyList(bool needClearItem)
	{
	}

	public void RefreshWeaponReinforcedIcons(bool showBeforeReinforced, bool isReinforced)
	{
	}

	private void RefreshSingleReinforcedIcon(UIHudWeaponPropertyItemView ctrl, AGACNOCEEFP weaponData, EWeaponScoreID scoreId)
	{
	}

	private bool IsWeaponMatchedReinforceAttachment(AGACNOCEEFP weaponData, uint attachmentItemId, GIANNEDDMLL expectedSlot)
	{
		return false;
	}

	private bool IsReinforceAffectScore(AGACNOCEEFP weaponData, EWeaponScoreID scoreId)
	{
		return false;
	}
}
