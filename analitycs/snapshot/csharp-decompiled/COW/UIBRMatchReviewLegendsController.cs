using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIBRMatchReviewLegendsController : UIBaseController
{
	private UIBRMatchReviewLegendsView m_View;

	private List<UIBRMatchReviewLegendItemController> m_ItemControllers;

	private Dictionary<EBRMatchReviewLegendType, bool> m_ToggleStates;

	private UIBRMatchReviewController ReviewCtrl => null;

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

	public void SetData(List<IHEPBAGKINP> mapObjects)
	{
	}

	private void AddLegendItem(EBRMatchReviewLegendType type, bool defaultOn)
	{
	}

	private bool GetOrCreateToggleState(EBRMatchReviewLegendType type, bool defaultOn)
	{
		return false;
	}

	private void ApplyToggleStatesToReview()
	{
	}

	private static HashSet<OCGKABKDAKP> CollectInteractedTypes(List<IHEPBAGKINP> mapObjects)
	{
		return null;
	}

	public void OnLegendItemToggled(EBRMatchReviewLegendType type, bool isOn)
	{
	}

	public bool GetToggleState(EBRMatchReviewLegendType type)
	{
		return false;
	}

	public void ClearData()
	{
	}

	private void ClearItems()
	{
	}

	private void OnCloseClicked()
	{
	}

	private static string GetLegendSpriteName(EBRMatchReviewLegendType type)
	{
		return null;
	}

	private static string GetLegendLocKey(EBRMatchReviewLegendType type)
	{
		return null;
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
