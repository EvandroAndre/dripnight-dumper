using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHUDRushingPetsMatchResultController : UIHudSingleFightMatchResultController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TeammateStats> _003C_003E9__8_0;

		internal int _003CProcesssStatesList_003Eb__8_0(TeammateStats a, TeammateStats b)
		{
			return 0;
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool IsNeedShowAvatar()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool IsShowDetailBtn()
	{
		return false;
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void UpdateInfoTitles()
	{
	}

	protected override UIHudSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	protected override List<TeammateStats> ProcesssStatesList(List<TeammateStats> orgList, ulong localAccountID)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsShowDetailBtn()
	{
		return false;
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}

	public UIHudSingleFightMatchResultItemController _003C_003EiFixBaseProxy_OpenItemController(TeammateStats P0, bool P1)
	{
		return null;
	}

	public List<TeammateStats> _003C_003EiFixBaseProxy_ProcesssStatesList(List<TeammateStats> P0, ulong P1)
	{
		return null;
	}
}
