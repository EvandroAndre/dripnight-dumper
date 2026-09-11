using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDetailTipsWithDownloadController : UIDetailTipsController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public CSSharedItemData itemData;

		public UIDetailTipsWithDownloadController _003C_003E4__this;

		public UINewDownloadInfoController downloadCtrl;

		internal void _003CRefreshOptionalDownloadShow_003Eb__0()
		{
		}
	}

	protected bool m_DownloadReay;

	private List<ResourceID> m_ResList;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshOptionalDownloadShow()
	{
	}

	public void SetDataWithOptionalDownload(BaseItemInfo info, Vector3 itemPos, bool showTypeIcon = true)
	{
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}
