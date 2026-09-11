using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraOperationBtnOutInGameController : UIHudCameraOperationBtnController, IUIModelDataChangeObserver
{
	private const float VEDIO_REC_BTN_OFFEST_POS_Y = -0.37f;

	private ECameraOperationBtnFrom OpenFrom;

	private Camera TargetCamera;

	private Vector3 CameraInitialPos;

	private Quaternion CameraInitialRot;

	private bool m_IsGroupPhoto;

	private bool m_IsSeasonReplay;

	private bool m_IsSeasonReplayBR;

	private bool m_IsSquadTreasure;

	private float DefaultDist;

	private bool CurIsInGroup;

	private UIModelGroup m_ModelGroup;

	private float m_PreZoom;

	private float m_BeforeGroupJoinZoom;

	private bool m_IsHasChangeScroll;

	private UITakePhotoGroupBaseController GroupParent;

	private float ZoomMax;

	private Vector3 FocusPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void InitZoom()
	{
	}

	public void OnGroupJoinSetAvatarPos()
	{
	}

	public bool IsHasChangeScroll()
	{
		return false;
	}

	public void SetTargetCamera(Camera camera)
	{
	}

	public void SetPanelDepth(int dep)
	{
	}

	private UIUtils.ScreenshotType GetScreenshotType()
	{
		return UIUtils.ScreenshotType.None;
	}

	protected override void OnMainBtnClick()
	{
	}

	private bool StartRecord()
	{
		return false;
	}

	private void StopRecord()
	{
	}

	public void ResetMainBtnPos()
	{
	}

	protected override void RefreshMainBtn(ECameraState CameraState)
	{
	}

	public void SetGroupPhoto(bool isGroupPhoto, UITakePhotoGroupBaseController groupParent)
	{
	}

	public void SetSeasonReplay(bool isSeasonReplay, bool isBR)
	{
	}

	public void SetSquadTreasure(bool isSquadTreasure)
	{
	}

	public void SetFrom(ECameraOperationBtnFrom from)
	{
	}

	public override void AfterScreenshot()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	protected override void OnZoomChanged(float newVal)
	{
	}

	public void RecoverZoomAfterGroupJoin()
	{
	}

	protected override void OnScrollContainerPress(GameObject go, bool isPressed)
	{
	}

	protected override float GetZoomMin()
	{
		return 0f;
	}

	protected override float GetZoomBase()
	{
		return 0f;
	}

	protected override float GetZoomMax()
	{
		return 0f;
	}

	private Vector3 GetFocusLocalDir(bool force = false)
	{
		return default(Vector3);
	}

	public void Refresh()
	{
	}

	public void OnLobbyShow()
	{
	}

	public void OnLobbyHide()
	{
	}

	private void ResetTargetCameraPos()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ResetTargetCamera()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnSideBtnClick()
	{
	}

	protected override void RefreshVedioBtnState()
	{
	}

	private bool IsHDLobby()
	{
		return false;
	}

	protected override void OnSaveRecordCallback(bool result, string message)
	{
	}

	public UIWidget GetWidget()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitZoom()
	{
	}

	public void _003C_003EiFixBaseProxy_OnMainBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshMainBtn(ECameraState P0)
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnZoomChanged(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnScrollContainerPress(GameObject P0, bool P1)
	{
	}

	public float _003C_003EiFixBaseProxy_GetZoomMin()
	{
		return 0f;
	}

	public float _003C_003EiFixBaseProxy_GetZoomBase()
	{
		return 0f;
	}

	public float _003C_003EiFixBaseProxy_GetZoomMax()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSideBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVedioBtnState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSaveRecordCallback(bool P0, string P1)
	{
	}
}
