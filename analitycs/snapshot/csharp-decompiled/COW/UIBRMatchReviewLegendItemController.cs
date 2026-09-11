using GCommon;

namespace COW;

public class UIBRMatchReviewLegendItemController : UIBaseController
{
	private UIBRMatchReviewLegendItemView m_View;

	private EBRMatchReviewLegendType m_Type;

	private bool m_IsOn;

	private UIBRMatchReviewLegendsController LegendsCtrl => null;

	public EBRMatchReviewLegendType LegendType => EBRMatchReviewLegendType.EnemyPosition;

	public bool IsOn => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(EBRMatchReviewLegendType type, string spriteName, string locKey, bool isOn)
	{
	}

	private void OnToggleClicked()
	{
	}

	private void RefreshToggleVisual()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
