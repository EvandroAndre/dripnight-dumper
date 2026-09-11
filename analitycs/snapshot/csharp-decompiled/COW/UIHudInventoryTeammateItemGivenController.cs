using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudInventoryTeammateItemGivenController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIInventoryTeammateItemGiven> _003C_003E9__23_0;

		public static Action<UIInventoryTeammateItemGiven> _003C_003E9__29_0;

		internal int _003CRepositionByTeamIndex_003Eb__23_0(UIInventoryTeammateItemGiven a, UIInventoryTeammateItemGiven b)
		{
			return 0;
		}

		internal void _003CUpdateTeammateState_003Eb__29_0(UIInventoryTeammateItemGiven e)
		{
		}
	}

	private UIHudInventoryTeammateItemGivenView m_View;

	private List<UIInventoryTeammateItemGiven> m_TeammatesList;

	private Dictionary<BHGGAEEHJCO, UIInventoryTeammateItemGiven> m_TeammatesDic;

	private UIModelMatch m_ModelMatch;

	private float m_ItemHeight;

	private float m_DisSqr;

	private BHGGAEEHJCO m_CurHoverPlayerID;

	private UIItem m_CurUIItem;

	private uint m_CurTickCnt;

	private const uint TICK_INTERVAL = 4u;

	private uint m_TutorialDelayCallID;

	private bool m_HasTutorialTriggered;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnTeammateAdd(MatchTeam.KMGBNNHDOHF info)
	{
	}

	private void OnTeammateInfoSync(object[] data)
	{
	}

	private void OnDragDropHover(object[] data)
	{
	}

	public void OnInventoryDragAndDrop(object[] data)
	{
	}

	private void RepositionByTeamIndex()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowTutorial(UIWidget widget)
	{
	}

	private void HideTutorialNode()
	{
	}

	private void Update()
	{
	}

	private void UpdateTeammateState()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
