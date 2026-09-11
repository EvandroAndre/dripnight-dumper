using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBigEvent_Template_LoadingMaskPopupWndBaseController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private UIBigEvent_Template_LoadingMaskPopupWndView m_View;

	protected List<int> m_ListNeedDownloadCdnConfigKey;

	protected int m_NeedDownloadCdnCount;

	protected int m_HaveDownloadedCdnCount;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		protected set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	protected virtual void SetInfoBeforeRefreshView()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	protected void RefreshView()
	{
	}

	private void RefreshProgressBar()
	{
	}

	private void OnCdnDownloadCallback(object[] data)
	{
	}

	private void OnClickBtnClose()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	protected virtual void RefreshLoadingMaskNeedDownloadCdn()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
