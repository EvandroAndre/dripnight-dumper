using System;
using GCommon;

namespace COW;

public class UIUGCPremiumCardController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIDetailTipsController ctrl;

		public Action _003C_003E9__1;

		internal void _003COnClickCard_003Eb__0(int i, UIDetailTipsBtnItemController goBtn)
		{
		}

		internal void _003COnClickCard_003Eb__1()
		{
		}
	}

	public Action onClickAction;

	private UIUGCPremiumCardView m_View;

	private UIModelUGCPremium m_UGCPremium;

	private bool m_ShowRedPoint;

	public UIButton Button => null;

	public UIWidget GuideNode => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnClickCard()
	{
	}

	private string GetRedPointKey()
	{
		return null;
	}

	private void RefreshCardStatus()
	{
	}

	private void OnPlayerPremiumChanged(int data)
	{
	}

	public void PlayActiveAnim()
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
