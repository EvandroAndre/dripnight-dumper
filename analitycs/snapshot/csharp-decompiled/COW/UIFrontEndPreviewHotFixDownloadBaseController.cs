using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIFrontEndPreviewHotFixDownloadBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewHotFixDownloadBaseView>
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIFrontEndPreviewHotFixDownloadBaseController _003C_003E4__this;

		public List<ResourceID> res_list;

		public string tempname;

		internal void _003CSetOptionalDownloadShow_003Eb__0()
		{
		}
	}

	protected DownloadInfoSpecific m_DownloadInfoSpecific;

	protected UINewDownloadInfoController m_DownloadCtrl;

	protected ResDownloadType m_DownloadAllType;

	protected override void InitView()
	{
	}

	protected override void OnSetFrontEndPreviewUIConfigData()
	{
	}

	public void SetDownloadAllInfo(bool NeedShowDownloadAllBtn, ResDownloadType temptype = ResDownloadType.None, string downlownadllstr = "")
	{
	}

	protected virtual void OnClickAll()
	{
	}

	public Vector2 GetItemDownloadBtnPos()
	{
		return default(Vector2);
	}

	public bool GetHotFixShow()
	{
		return false;
	}

	public virtual void SetOptionalDownloadShow(bool show, DownloadInfoSpecific downloadInfo = null, bool isAvatar = false)
	{
	}

	public void Download()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetFrontEndPreviewUIConfigData()
	{
	}
}
