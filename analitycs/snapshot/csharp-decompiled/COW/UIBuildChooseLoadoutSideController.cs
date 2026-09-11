using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseLoadoutSideController : UIBaseChooseLoadoutPopupWindowController
{
	private UICommonGuideController m_GuideController;

	private UIBuildChooseLoadoutSideView m_View;

	private const float CSBP_TOP_OFFSET = 42f;

	private const float CSBP_BOTTOM_OFFSET = 36f;

	private Vector3 m_OriginalLoadoutPanelNewPosition;

	private Vector3 m_OriginalLoadoutNameLabelPosition;

	private Vector3 m_OriginalBgPosition;

	private int m_OriginalBgHeight;

	private Vector3 m_OriginalContainerBGPosition;

	private int m_OriginalContainerBGHeight;

	private Vector3 m_OriginalCDNTextureTutorialsPosition;

	private UICommonGuideController m_GuideCtrl;

	private uint m_DelayShowGuideId;

	private float m_DelayShowGuideTime;

	private int m_GuideAvatarLoadoutStep;

	private int m_GuidePetLoadoutStep;

	private bool m_ForbidEsc;

	public bool ForbidEsc
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshLoadoutAndStyle()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void Awake()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	protected override void InitView()
	{
	}

	protected override void InitV1ViewWhenV2Open()
	{
	}

	protected override void OnSelectLoadout(int itemIdx)
	{
	}

	protected override void RefreshLoadout()
	{
	}

	protected override UIBaseChooseLoadoutItemController GetItemController()
	{
		return null;
	}

	protected override void InitLoadoutV2Ctrl()
	{
	}

	private void BuildCloseSide()
	{
	}

	private void InitGuide()
	{
	}

	private void StartGuide()
	{
	}

	private void DelayShowGuide()
	{
	}

	private void TryShowNewLoadoutTutorial()
	{
	}

	private void OnCheckLoadoutV2Guide(uint step)
	{
	}

	private void ChangeForbidEscState(bool isForbid)
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void SaveOriginalLayout()
	{
	}

	private void ApplyCSBPLayout()
	{
	}

	public void ShowFirstLoadoutItemTutorial()
	{
	}

	public void HideFirstLoadoutItemTutorial()
	{
	}

	private void _003CStartGuide_003Eb__31_0()
	{
	}

	private void _003CDelayShowGuide_003Eb__32_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_InitV1ViewWhenV2Open()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectLoadout(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshLoadout()
	{
	}

	public UIBaseChooseLoadoutItemController _003C_003EiFixBaseProxy_GetItemController()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_InitLoadoutV2Ctrl()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
