using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCenterBigEventTemplateController : UIBaseController
{
	public enum EntranceLocation
	{
		None,
		BigEvent,
		RevBtn
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__15_0;

		internal void _003CUpdateBigEventTemplateEntrance_003Eb__15_0()
		{
		}
	}

	private UIUGCCenterBigEventTemplateView m_View;

	private UICountDownController m_BigEventTemplateCountDownCtrl;

	private UINewDownloadInfoController m_BigEventTemplateEntranceDownloadCtrl;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private float m_NextCheckTime;

	private ResourceID m_BigEventTemplateEntranceEffectVFXResID;

	private GameObject m_BigEventTemplateEntranceEffectVFXGO;

	private EBigEventTemplateUseType m_TemplateUseType;

	private EntranceLocation m_EntranceLocation;

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

	private void OnClickBtnBigEventTemplate()
	{
	}

	private void InitBtnBigEventTemplateClickSound()
	{
	}

	public void UpdateBigEventTemplateEntrance(int entranceLocation)
	{
	}

	public void RefreshRedTips()
	{
	}

	public void RefreshTemplateBigEventEntranceDownloadState()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetTemplateUseType(EBigEventTemplateUseType useType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
