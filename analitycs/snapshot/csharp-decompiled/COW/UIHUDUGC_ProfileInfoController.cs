using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ProfileInfoController : UIHUDUGC_WidgetBaseController
{
	public UGCHudProfileInfo m_ProfileInfo;

	private UGCHudProfileInfoRepItem m_ProfileInfoCmpt;

	private UGCProfileInfoRepItem m_InfoCmpt;

	protected override void OnDestroy()
	{
	}

	protected override void InitEntityData()
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	public override void BindWidget(UGCHudWidget widget)
	{
	}

	public override void RefreshAlpha()
	{
	}

	protected void OnScaleChanged(Vector3 cur)
	{
	}

	private void OnHeadIDChanged(string cur)
	{
	}

	private void OnBannerIDChanged(string cur)
	{
	}

	private void OnPinIDChanged(string cur)
	{
	}

	private void OnNickNameChanged(string cur)
	{
	}

	private void OnBRRankChanged(int rank)
	{
	}

	private void OnBRPeakRankChanged(int peak)
	{
	}

	private void OnCSRankChanged(int rank)
	{
	}

	private void OnCSPeakRankChanged(int peak)
	{
	}

	private void OnShowTypeChanged(int cur)
	{
	}

	private void OnShowRankChanged(int cur)
	{
	}

	private void OnShowPinChanged(bool cur)
	{
	}

	private void OnShowNameChanged(bool cur)
	{
	}

	private void OnProfileInfoChanged(string id)
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public new void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_BindWidget(UGCHudWidget P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAlpha()
	{
	}
}
