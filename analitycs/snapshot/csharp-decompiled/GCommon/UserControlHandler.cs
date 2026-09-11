using System.Collections.Generic;
using COW;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using message;

namespace GCommon;

internal class UserControlHandler
{
	private UserControlMapping m_UserControlMapping;

	private InputManagerActionMap m_InputManagerActionMap;

	private UGCInputSystemActionHandler m_UGCInputSystemActionHandler;

	private float[] m_RawDataCache;

	private Dictionary<string, int> m_RawKeyCodeCache;

	private Dictionary<string, int> m_LastRawRawKeyCodeDataCache;

	private Dictionary<string, double> m_LastKeyCodePressTime;

	private static readonly Dictionary<int, string> m_GameControlToKeyAction;

	public const uint IS_BUTTONENABLE_PLAYERSTATUS = 1u;

	public const uint IS_BUTTONENABLE_CAMERAMODE = 2u;

	public const uint IS_BUTTONENABLE_FREEVIEW = 4u;

	private BitArrayBoolean m_IsButtonEnable;

	private BitArrayBoolean m_IsInputEnable;

	public const uint IS_MOVE_INPUT_PLAYER = 1u;

	public const uint IS_MOVE_INPUT_CAMERAMODE = 2u;

	private BitArrayBoolean m_IsMoveInputEnable;

	public const uint IS_ROTATE_INPUT_CAMERAMODE = 1u;

	private BitArrayBoolean m_IsRotateInputEnable;

	private UserControlAxisData[] m_AxisData;

	private float[] m_LastRawDataCache;

	private bool m_IsUserControlChanged;

	public bool IsUGCInteractWithHUD;

	private UserControlTouchData m_CurrentTouchData;

	private bool m_EnableRecordTouchInfo;

	private bool m_EnableFixStationaryAxisMoving;

	private float m_FixStationaryAxisMovingThreshold;

	private int m_FingerInDashArea;

	private bool m_LockFingerInDashArea;

	private float m_MistakenlyTouchCheckTime;

	private bool _003CDashByMovingJoystick_003Ek__BackingField;

	public const int SPEEDUP_LOCK_THRESHOLD = 3;

	public static float m_resolutionResetScale;

	private int m_LastButtonChangedFc;

	private bool m_UseCachedButtons;

	private bool m_AllowForceCheckBtnChange;

	private CrossPlatformInputManager.VirtualButton[] m_CachedButtons;

	private Vector2 m_MouseInputRawPosition;

	private Dictionary<int, Vector2> m_FingerRawPosDict;

	private Dictionary<int, bool> m_FingerRawPosConflictWithButtonDict;

	public bool UsingPreNormailizeDirection;

	public bool UsingFixDirection;

	public bool EnableZAxis;

	private UIModelSetting m_ModelSetting;

	private bool m_HasAxisHandled;

	private Dictionary<int, TouchHitInfo> m_HitInfosCache;

	private ObjectPool<TouchHitInfo> m_TouchInfoPool;

	public float[] RawDataCache
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool DashByMovingJoystick
	{
		get
		{
			return _003CDashByMovingJoystick_003Ek__BackingField;
		}
		set
		{
			_003CDashByMovingJoystick_003Ek__BackingField = value;
		}
	}

	private void HandleAction(float gameTime = 0f, float deltaTime = 0f)
	{
	}

	public UserControlHandler()
	{
	}

	public UserControlHandler(bool isLocalPlayerAndUGCMode)
	{
	}

	public void CacheButtons()
	{
	}

	public void SetRecordTouchInfoEnable(bool enable)
	{
	}

	public void SetFixStationaryAxisMoving(bool enable, float threshold)
	{
	}

	public void SetButtonEnable(uint flag, bool enable)
	{
	}

	public bool IsLockPlayerMovement()
	{
		return false;
	}

	public bool IsLockCameraRotation()
	{
		return false;
	}

	public bool IsLockKeyAction(string kcMapName)
	{
		return false;
	}

	public void SetInputEnable(EInputEnableReason reason, bool enable)
	{
	}

	public void SetInputEnable(bool enable)
	{
	}

	public bool GetInputState()
	{
		return false;
	}

	public void EnableMoveInput(uint flag, bool enable)
	{
	}

	public void EnableRotateInput(uint flag, bool enable)
	{
	}

	public bool IsRotateInputEnable()
	{
		return false;
	}

	public void ResetButton(int key)
	{
	}

	public void ResetPressedDirty()
	{
	}

	public void ResetButtonClick()
	{
	}

	public void AddAxisData(int hKey, int vKey, float acturallyMovedDist, UserControlAxisData.EAxisDataType t)
	{
	}

	public void RefreshAxisData()
	{
	}

	public void UpdateAxis(float gameTime = 0f, float deltaTime = 0f)
	{
	}

	public void UpdateRawDataCache(int axisIndex)
	{
	}

	public void Update(float gameTime = 0f, float deltaTime = 0f)
	{
	}

	public void UpdateRightAxis()
	{
	}

	private void RecordTouchInfo()
	{
	}

	public bool IsAuxAimBtnDown()
	{
		return false;
	}

	public bool IsButtonDown(int key)
	{
		return false;
	}

	public bool IsButtonDown(string kcMapName)
	{
		return false;
	}

	public bool IsButtonReleased(int key)
	{
		return false;
	}

	public bool IsButtonReleased(int key, bool checkPressedDirty)
	{
		return false;
	}

	public bool IsKeyActionReleased(string kcMapName)
	{
		return false;
	}

	public bool IsButtonPressed(int key)
	{
		return false;
	}

	private bool IsUseButtonClick(int key)
	{
		return false;
	}

	public bool IsButtonClick(int key)
	{
		return false;
	}

	public bool IsKeyActionPressed(string kcMapName)
	{
		return false;
	}

	public bool IsKeyActionDoubleClick(string kcMapName)
	{
		return false;
	}

	public bool HaveRecoredTouchPosition()
	{
		return false;
	}

	public Vector3 GetRecordedTouchPosition()
	{
		return default(Vector3);
	}

	public bool IsUserControlChanged()
	{
		return false;
	}

	public Vector3 GetDirectionLeft()
	{
		return default(Vector3);
	}

	public Vector3 GetAxisDeltaLeft()
	{
		return default(Vector3);
	}

	public Vector3 GetDirectionRight()
	{
		return default(Vector3);
	}

	public Vector3 GetAxisDeltaRight()
	{
		return default(Vector3);
	}

	public Vector3 GetDirectionWeaponSlider()
	{
		return default(Vector3);
	}

	public Vector3 GetAxisDeltaWeaponSlider()
	{
		return default(Vector3);
	}

	public Vector3 GetDirectionRouletteSilder()
	{
		return default(Vector3);
	}

	public Vector3 GetAxisDeltaRouletteSlider()
	{
		return default(Vector3);
	}

	public UserControlAxisData GetAxisData(int axisIndex)
	{
		return null;
	}

	public Vector3 GetShiftedDirectionWithCamera(Camera camera, int axisIndex = 0)
	{
		return default(Vector3);
	}

	private bool IsAxisChanged(Vector3 curVec, Vector3 lastVec)
	{
		return false;
	}

	private bool CheckMistakenlyTouchMovingJoystick(Vector3 pos, UserControlAxisData axisData)
	{
		return false;
	}

	private bool CheckMovingJoystickConflictWithButton(UserControlAxisData axisData, Vector2 rawPos, int fingerId)
	{
		return false;
	}

	private void UpdateInputRawPosition()
	{
	}

	private void UpdateSingleAxis(int axisIndex, Dictionary<int, TouchHitInfo> hitInfosCache, ref bool inited)
	{
	}

	private bool OnTouchBegin(UserControlAxisData axisData)
	{
		return false;
	}

	private bool OnTouchMove(UserControlAxisData axisData)
	{
		return false;
	}

	private bool OnTouchStationary(UserControlAxisData axisData)
	{
		return false;
	}

	private bool OnTouchEnd(UserControlAxisData axisData)
	{
		return false;
	}

	private void UpdateSpeedUpStates(UserControlAxisData axisData, TouchPhase tp)
	{
	}

	public void CleanupTouchData(UserControlAxisData axisData)
	{
	}

	public void SetFingerDashArea(int area)
	{
	}

	public bool IsFingerInDashArea()
	{
		return false;
	}

	public void SetLockFingerInDashArea(bool isLock)
	{
	}

	public bool IsActionAcitve(KPAEFNMDJKE action)
	{
		return false;
	}

	private bool IsKeyInputOverride(int keyCode)
	{
		return false;
	}

	public void OnDestroy()
	{
	}

	public void ClearAxisData(int axisIndex)
	{
	}
}
