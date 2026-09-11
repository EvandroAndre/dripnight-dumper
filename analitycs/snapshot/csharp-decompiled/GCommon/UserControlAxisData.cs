using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace GCommon;

public class UserControlAxisData
{
	public enum EAxisDataType
	{
		Left,
		Right,
		WeaponSlider,
		RouletteSlider,
		MedkitSlider,
		GrenadeSlider,
		AssistMarkSlider,
		BotAgentMarkSlider,
		MapThrowerSlider
	}

	public Vector3 Direction;

	public Vector3 DeltaPos;

	public Vector3 LastDirection;

	public UserControlTouchInfo TouchInfo;

	public UserControlTouchInfo LastTouchInfo;

	private bool _003CIsEnableAxisX_003Ek__BackingField;

	private bool _003CIsEnableAxisY_003Ek__BackingField;

	private bool m_IsEnable;

	private bool m_IsTouched;

	private bool m_IsActuallyMoved;

	private bool m_IsCheckUpperPanel;

	private bool m_HasPopupMask;

	private bool m_IsInBegin;

	private bool m_IsBegan;

	private Vector3 m_CurrentDeltaValue;

	private Vector3 m_StartScreenPos;

	private Vector3 m_CurrentScreenPos;

	private bool m_UseButtonAreaRange;

	private bool m_UseDirectionOriginOverride;

	private Vector3 m_DirectionOriginOverride;

	private float m_ActuallyMovedDistance;

	public Vector3 SwipeDirection;

	private EAxisDataType m_AxisDataType;

	private Dictionary<int, UserButtonArea> m_TouchingThroughArea;

	private bool m_ShouldCheckUGCCustomUITouchThrough;

	private CrossPlatformInputManager.VirtualAxis m_HVirtualAxis;

	private CrossPlatformInputManager.VirtualAxis m_VVirtualAxis;

	private string m_HVirtualName;

	private string m_VVirtualName;

	private UIRoot m_UIRoot;

	private bool m_bIsCheckDisableInputInfo;

	private Dictionary<int, Vector2> m_dicDisableInputInfo;

	public bool IsEnableAxisX
	{
		get
		{
			return _003CIsEnableAxisX_003Ek__BackingField;
		}
		private set
		{
			_003CIsEnableAxisX_003Ek__BackingField = value;
		}
	}

	public bool IsEnableAxisY
	{
		get
		{
			return _003CIsEnableAxisY_003Ek__BackingField;
		}
		private set
		{
			_003CIsEnableAxisY_003Ek__BackingField = value;
		}
	}

	public bool IsAxisEnabled => false;

	public bool HasPopupMask
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBegan => false;

	private UIRoot Root => null;

	public EAxisDataType GetAxisDataType()
	{
		return EAxisDataType.Left;
	}

	public UserControlAxisData(string hName, string vName, float acturallyMovedDist, EAxisDataType t)
	{
	}

	public void RegisterAxis()
	{
	}

	public int GetTouchFinger()
	{
		return 0;
	}

	private bool UseButtonAreaRange()
	{
		return false;
	}

	public bool IsInRange(Vector3 v)
	{
		return false;
	}

	private bool IsButtonArea(Vector3 v)
	{
		return false;
	}

	public bool IsStationary()
	{
		return false;
	}

	public bool CanTouchingThrough(Vector2 pos, int fingerIndex, int touchIndex, Dictionary<int, TouchHitInfo> hitInfosCache)
	{
		return false;
	}

	public bool CheckCanTouchThroughUGCCustomUI(GameObject hitObject)
	{
		return false;
	}

	public void RefreshUGCCustomUITouchThroughCheck()
	{
	}

	public bool IsSpeedupButtonArea(Vector3 v)
	{
		return false;
	}

	public void UpdateValue(Vector3 pos, Vector3 deltaValue)
	{
	}

	public Vector3 GetCurrentScreenPos()
	{
		return default(Vector3);
	}

	public bool CheckIsInBegin()
	{
		return false;
	}

	public void OnBegin(Vector3 startPos, Vector3 deltaPos)
	{
	}

	public void OnEnd()
	{
	}

	public void OnMove(Vector3 lastPos, Vector3 curPos)
	{
	}

	public void OnStationary(Vector3 lastPos, Vector3 curPos, bool doFix, float threshold)
	{
	}

	public void UpdateDirection()
	{
	}

	public Vector3 GetDelta()
	{
		return default(Vector3);
	}

	public bool IsTouched()
	{
		return false;
	}

	public Vector3 GetStartScreenPos()
	{
		return default(Vector3);
	}

	public void SetUseButtonAreaRange(bool enable)
	{
	}

	public void SetDirectionOriginOverride(bool enable, Vector3 origin)
	{
	}

	public void SetVirtualAxes()
	{
	}

	public void AddTouchingThroughArea(int key, UserButtonArea area)
	{
	}

	public void EnableTouchingThroughArea(int key, bool v)
	{
	}

	public void EnableCheckUpperPanel(bool enable)
	{
	}

	public void EnableAxis(bool enable)
	{
	}

	public void EnableAxisX(bool enable)
	{
	}

	public void EnableAxisY(bool enable)
	{
	}

	private bool CheckDisableInputInfo(int fingerIndex)
	{
		return false;
	}

	public void RecordDisableInputInfo(int fingerIndex, Vector2 rawPosition)
	{
	}

	public void EnableCheckFingerIndexAndRawPosition(bool b)
	{
	}
}
