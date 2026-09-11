using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using RuntimeGizmos;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditItemAdjustSimplePanelController : UIHudUGCTutorialRestrictionBaseController
{
	private UIHudSceneEditItemAdjustSimplePanelView m_View;

	private MutableString m_Str;

	private UIModelSceneEdit m_Model;

	private SceneEditAgent m_Agent;

	private HNDHJGJILHC m_Game;

	private WorkshopSceneData m_WorkshopSceneData;

	private const int DROP_LIST_WIDTH = 172;

	private UIPopMenuSmallControler mMovePopMenuCtrl;

	private UIPopMenuSmallControler mScalePopMenuCtrl;

	private Dictionary<int, string> mScalePopMap;

	private UIPopMenuSmallControler mRotatePopMenuCtrl;

	private Dictionary<int, string> mRotatePopMap;

	private bool m_IsPreciseEdit;

	private Vector3 m_PreciseData;

	private Vector3 m_TempPreciseData;

	private bool m_HasPreferredEulerAngles;

	private Vector3 m_PreferredEulerAngles;

	private bool m_IsUpdatingTimelineKeyFrame;

	protected List<PopMenuData> mPopMenuDataList;

	private Dictionary<int, UISprite> mModifyButtonIcons;

	private List<GameObject> m_PreciseContainer;

	private bool m_ForceHide;

	private SceneEditObjectBase m_TargetObj;

	protected Dictionary<ulong, UIButton> m_ButtonMaps;

	private AdjustButtonStateHandlerBase m_buttonHandler;

	private SceneEditAgent Agent => null;

	private EAdjustType CurAdjustType => EAdjustType.None;

	private WorkshopSceneData WorkshopSceneData => null;

	public AdjustButtonStateHandlerBase ButtonHandler => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnDescChange()
	{
	}

	private void OnResModeChanged(object[] data)
	{
	}

	public void OnSelectedObjChanged()
	{
	}

	private void OnSelectedTrackChanged()
	{
	}

	private void OnOperateChanged()
	{
	}

	private void OnModifyChanged()
	{
	}

	public void OnAdjustTypeChange()
	{
	}

	private void UpdatePopMenu()
	{
	}

	private void OnEntityGetter(object[] data)
	{
	}

	private void OnCameraModeChange()
	{
	}

	private void OnReposition()
	{
	}

	private void OnClickAdjustBtn(EAdjustType type)
	{
	}

	private void UpdateButtonStatus()
	{
	}

	public void UpdateCoordinate()
	{
	}

	private void OnUpdateCoordinateFromTimeline()
	{
	}

	public void SetCoordinateLabel(EAdjustType adjustType)
	{
	}

	private void RefreshCoordinateLabelFromDataChange(EAdjustType adjustType)
	{
	}

	private void RefreshPreciseDataFromDataChange(EAdjustType adjustType)
	{
	}

	private void UpdatePreciseCoordinate()
	{
	}

	private string GetCoordinateString(Vector3 data)
	{
		return null;
	}

	private void ResetPreferredEulerAngles()
	{
	}

	private void SetPreferredEulerAngles(Vector3 eulerAngles)
	{
	}

	private Vector3 GetPreferredEulerAngles(Vector3 rawEulerAngles)
	{
		return default(Vector3);
	}

	private bool TryGetCoordinateValue(EAdjustType adjustType, out Vector3 value)
	{
		value = default(Vector3);
		return false;
	}

	private bool TryGetTimelineKeyFrameValue(EAdjustType adjustType, out Vector3 value)
	{
		value = default(Vector3);
		return false;
	}

	private bool TryGetTimelinePropID(EAdjustType adjustType, out int propID)
	{
		propID = default(int);
		return false;
	}

	private bool TryGetAdjustTypeByTimelinePropID(int propID, out EAdjustType adjustType)
	{
		adjustType = default(EAdjustType);
		return false;
	}

	private bool TryGetAddKeyFrameAdjustType(out EAdjustType adjustType)
	{
		adjustType = default(EAdjustType);
		return false;
	}

	private bool IsSameTimelineKeyFrameValue(EAdjustType adjustType, Vector3 value)
	{
		return false;
	}

	private void BindCoordinateTarget(SceneEditObjectBase target)
	{
	}

	private void UnbindCoordinateTarget()
	{
	}

	private void AttachCoordinateTargetDelegates()
	{
	}

	private void DetachCoordinateTargetDelegates()
	{
	}

	private void OnTargetObjMoved()
	{
	}

	private void OnTargetObjRotated()
	{
	}

	private void OnTargetObjScaled()
	{
	}

	private void OnTargetObjTangentMoved()
	{
	}

	private void InitPopMenu()
	{
	}

	private void GenerateRotateMenuData()
	{
	}

	private void OnRotateSelected(object obj)
	{
	}

	private void GenerateScaleMenuData()
	{
	}

	private void OnScaleSelected(object obj)
	{
	}

	private void ExitPreciseEdit()
	{
	}

	private void OnClickBtnPreciseEdit()
	{
	}

	private void SetModifyObjData(float target, Axis axis)
	{
	}

	private void SetPreciseStep(Axis axis, ref float step)
	{
	}

	private void OnClickBtnChange(Axis axis, bool bAdd)
	{
	}

	private void OnSubmitInput(Axis axis)
	{
	}

	private void OnBtnGroup()
	{
	}

	private void OnBtnUngroup()
	{
	}

	private void OnBtnDuplicate()
	{
	}

	private void OnBtnDelete()
	{
	}

	private void OnBtnSave()
	{
	}

	private void OnBtnFPV()
	{
	}

	public override void Show()
	{
	}

	private void OnAddSubTrackBtn()
	{
	}

	private void OnTimelineSettingBtn()
	{
	}

	private void OnAddTrackBtn()
	{
	}

	private void OnAddKeyFrameBtn()
	{
	}

	private void OnDeleteTrackBtn()
	{
	}

	private void OnDeleteKeyFrameBtn()
	{
	}

	private void OnAddKeyClipBtn()
	{
	}

	private void OnDeleteKeyClipBtn()
	{
	}

	private void TimelineModeUpdateKeyFrame(EAdjustType type, Vector3 value)
	{
	}

	public UIWidget GetTutorialAttributeButtonWidget()
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	private void _003COnUIInit_003Eb__34_0()
	{
	}

	private void _003COnUIInit_003Eb__34_1()
	{
	}

	private void _003COnUIInit_003Eb__34_2()
	{
	}

	private void _003COnUIInit_003Eb__34_3()
	{
	}

	private void _003COnUIInit_003Eb__34_4()
	{
	}

	private void _003COnUIInit_003Eb__34_5()
	{
	}

	private void _003COnUIInit_003Eb__34_6()
	{
	}

	private void _003COnUIInit_003Eb__34_7()
	{
	}

	private void _003COnUIInit_003Eb__34_8()
	{
	}

	private void _003COnUIInit_003Eb__34_9()
	{
	}

	private void _003COnUIInit_003Eb__34_10()
	{
	}

	private void _003COnUIInit_003Eb__34_11()
	{
	}

	private void _003COnUIInit_003Eb__34_12()
	{
	}

	private void _003COnUIInit_003Eb__34_13()
	{
	}

	private void _003COnAddKeyClipBtn_003Eb__96_0(bool state)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
