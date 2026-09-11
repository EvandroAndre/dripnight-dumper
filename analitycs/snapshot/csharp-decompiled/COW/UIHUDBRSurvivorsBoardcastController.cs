using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDBRSurvivorsBoardcastController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__11_0;

		internal void _003CUpdateAliveCnt_003Eb__11_0()
		{
		}
	}

	private UIHUDBRSurvivorsBoardcastView m_View;

	private UIHudNinth_GPWeaponAwakenSurvivorBoardcastController m_NinthCtrl;

	private UIModelMatch m_MatchModel;

	private List<int> m_RemainingPlayerCount;

	private int m_ShowedIndex;

	private uint m_DelayID;

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

	public override void OnUIReInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void UpdateAliveCnt(int cnt)
	{
	}

	private void GoHide()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
