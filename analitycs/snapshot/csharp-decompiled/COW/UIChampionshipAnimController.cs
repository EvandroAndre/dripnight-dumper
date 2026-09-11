using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIChampionshipAnimController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private abstract class ChampionshipAnimBase : IComparable<ChampionshipAnimBase>
	{
		public string m_AnimTrigger;

		public uint m_NotifyFlag;

		protected uint m_SortIndex;

		protected UIChampionshipAnimController m_Ctrl;

		protected uint m_CurrentChampionshipID;

		protected uint m_ChampionshipType;

		public virtual void InitAnimInfo()
		{
		}

		public virtual void SetAnimCSInfo()
		{
		}

		public ChampionshipAnimBase(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}

		public int CompareTo(ChampionshipAnimBase other)
		{
			return 0;
		}
	}

	private class AwardAnim : ChampionshipAnimBase
	{
		private ChampionshipInfo championshipInfo;

		public AwardAnim(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}

		public override void InitAnimInfo()
		{
		}

		private void RequestData()
		{
		}

		public override void SetAnimCSInfo()
		{
		}

		public void _003C_003EiFixBaseProxy_InitAnimInfo()
		{
		}

		public void _003C_003EiFixBaseProxy_SetAnimCSInfo()
		{
		}
	}

	private class AwardAnimNoPos : AwardAnim
	{
		public AwardAnimNoPos(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}
	}

	private class SeasonAnim : ChampionshipAnimBase
	{
		public SeasonAnim(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}

		public override void SetAnimCSInfo()
		{
		}

		public void _003C_003EiFixBaseProxy_SetAnimCSInfo()
		{
		}
	}

	public enum CSAnimType
	{
		Season,
		Award,
		AwardNoPos
	}

	public class CSAnimInfo
	{
		public CSAnimType m_AnimType;

		public uint m_ChampionshipType;
	}

	private UIChampionshipAnimView m_View;

	private UIModelChampionship m_ModelChampionship;

	private List<ChampionshipAnimBase> m_AnimList;

	private uint m_Flag;

	private Dictionary<uint, string> m_CupIconDict;

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

	protected override void OnUIClose()
	{
	}

	public void RefreshView(List<CSAnimInfo> m_AnimTypeList)
	{
	}

	private void AnimCreateFactory(List<CSAnimInfo> m_AnimInfoList)
	{
	}

	private void AnimListInit()
	{
	}

	private bool PlayAnim()
	{
		return false;
	}

	public void SetSeasonInfo(uint championshipID, uint championshipType)
	{
	}

	public void SetAwardInfo(uint championshipID, uint championshipType)
	{
	}

	private void SetRankNum(AccountChampionshipInfo accountInfo, uint localSize)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnGotoMailBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
