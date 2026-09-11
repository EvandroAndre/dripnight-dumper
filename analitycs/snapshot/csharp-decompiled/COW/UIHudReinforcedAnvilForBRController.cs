using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudReinforcedAnvilForBRController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Transform> _003C_003E9__4_0;

		internal int _003COnUIInit_003Eb__4_0(Transform item1, Transform item2)
		{
			return 0;
		}
	}

	private UIHudReinforcedAnvilForBRView m_View;

	private List<BHGGAEEHJCO> m_CreatedPlayerIDList;

	private List<UIHudReinforcedAnviTeammatePrimarySlotController> m_TeammateCtrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateTeammateData(bool force = false)
	{
	}

	private void ForceRefreshUI()
	{
	}

	private void OnLoadoutForceFinish()
	{
	}

	private void OnUIButtonCloseClick()
	{
	}

	private void OnAddLocalTeammate()
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
