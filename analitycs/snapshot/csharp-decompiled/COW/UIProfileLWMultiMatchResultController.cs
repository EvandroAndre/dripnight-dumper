using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileLWMultiMatchResultController : UIProfileBRMatchResultController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<List<TeammateStats>> _003C_003E9__4_0;

		internal int _003CSetupItems_003Eb__4_0(List<TeammateStats> a, List<TeammateStats> b)
		{
			return 0;
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override int[] GetInfoTypes(int type)
	{
		return null;
	}

	protected override void UpdateInfoTitles()
	{
	}

	private void SetupItems(MatchStats stats)
	{
	}

	public UIProfileMultiTeamMatchResultPlayerItemController BuildPlayerItem(Transform parent, TeammateStats player, bool single)
	{
		return null;
	}

	protected T OpenPlayerItemUI<T>(Transform parent, TeammateStats data, bool single) where T : UIHudMatchResultItemBaseController
	{
		return null;
	}

	public UIProfileMultiTeamMatchResultTeamItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private int SortTeamView(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int[] _003C_003EiFixBaseProxy_GetInfoTypes(int P0)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}
}
