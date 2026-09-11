using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIGameModeNewPlayerUnlockFeatureController : UIBaseController
{
	private UIGameModeNewPlayerUnlockFeatureView m_View;

	private DLBMPCCFKKM m_MatchMode;

	private NIKKALKPIBO m_GameMode;

	private uint m_UnlockEventID;

	private uint m_ActivityID;

	private bool m_HasInitDetailItem;

	private UIModelNewPlayerUnlockFeature m_ModelUnlockFeature;

	private GameplayAffixEventData m_ActivityEventData;

	private UIGameModeNewPlayerUnlockFeaturePreviewController m_GameModePreviewCtrl;

	public Vector2 NewPlayerTitleSize;

	public Vector2 FeatureTitleSize;

	public Vector2 FeatureItemSize;

	public Vector2 AffixDetailSize;

	public UITable2.Margin NewPlayerTitleMargin;

	public UITable2.Margin FeatureTitleMargin;

	public UITable2.Margin FeatureItemMargin;

	public UITable2.Margin AffixDetailMargin;

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

	public void AdjustPanelDepthWithBase(int dropdownBaseDepth)
	{
	}

	public void SetViewData(DLBMPCCFKKM matchMode, NIKKALKPIBO gameMode)
	{
	}

	public void OnNewPlayerUnlockFeaturePreviewEnd()
	{
	}

	public void RefreshDetailVisible(bool showDetail)
	{
	}

	private void PlayNewPlayerUnlockFeatureSequence()
	{
	}

	private void ShowPreviewOrMain(bool showPreview)
	{
	}

	private void OnDetailBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void InitTable2Template()
	{
	}

	private void InitDetailItem()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__28_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__28_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__28_2()
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
