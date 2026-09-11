using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassRewardItemBaseController : UIBaseController, UITable2.IUITable2Item
{
	private UIBooyahPassRewardItemBaseView m_View;

	protected UIModelBooyahPass m_ModelBooyahPass;

	protected List<UIBooyahPassMainBaseItemController> m_ListMainBaseItem;

	protected BooyahPassRewardItemData m_Data;

	private bool m_HasInitCDN;

	private string m_CurCDNUrl;

	private Color m_OriginColor;

	public UIBooyahPassRewardItemBaseView BaseView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void ShowUnlockEffect()
	{
	}

	public void RefreshCycleCdnView()
	{
	}

	public void RefreshGradeCdnView()
	{
	}

	public void RefreshBgCdnView()
	{
	}

	public virtual void RefreshView(object data, int index)
	{
	}

	protected virtual void RefreshItemView()
	{
	}

	protected virtual void RefreshStandardItemView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
