using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILadderMatchLobbyEntryController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CShowRankingGuide_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILadderMatchLobbyEntryController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowRankingGuide_003Ed__17(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private LadderMatchLobbyEntryView m_View;

	private UIModelLadderMatch m_LadderModel;

	private UIModelInventory m_InventoryModel;

	private UICommonGuideController m_GuideCtrl;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelUser m_ModelUser;

	private UIBRRankIconController m_BRRankIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CloseGuide()
	{
	}

	private void OnEntryClick()
	{
	}

	private void RefreshView()
	{
	}

	private void TryRefreshBRCrossModeView()
	{
	}

	private void RefreshOpeningUI()
	{
	}

	private IEnumerator ShowRankingGuide()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
