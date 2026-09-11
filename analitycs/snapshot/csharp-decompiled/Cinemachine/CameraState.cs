using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine;

public struct CameraState
{
	public enum BlendHintValue
	{
		Nothing = 0,
		NoPosition = 1,
		NoOrientation = 2,
		NoTransform = 3,
		SphericalPositionBlend = 4,
		CylindricalPositionBlend = 8,
		RadialAimBlend = 16,
		IgnoreLookAtTarget = 32,
		NoLens = 64
	}

	public class CustomBlendable
	{
		public Object m_Custom;

		public float m_Weight;

		public CustomBlendable(Object custom, float weight)
		{
		}
	}

	private LensSettings _003CLens_003Ek__BackingField;

	private Vector3 _003CReferenceUp_003Ek__BackingField;

	private Vector3 _003CReferenceLookAt_003Ek__BackingField;

	public static Vector3 kNoPoint;

	private Vector3 _003CRawPosition_003Ek__BackingField;

	private Quaternion _003CRawOrientation_003Ek__BackingField;

	private Vector3 _003CPositionDampingBypass_003Ek__BackingField;

	private float _003CShotQuality_003Ek__BackingField;

	private Vector3 _003CPositionCorrection_003Ek__BackingField;

	private Quaternion _003COrientationCorrection_003Ek__BackingField;

	private BlendHintValue _003CBlendHint_003Ek__BackingField;

	private CustomBlendable mCustom0;

	private CustomBlendable mCustom1;

	private CustomBlendable mCustom2;

	private CustomBlendable mCustom3;

	private List<CustomBlendable> m_CustomOverflow;

	private int _003CNumCustomBlendables_003Ek__BackingField;

	public LensSettings Lens
	{
		get
		{
			return _003CLens_003Ek__BackingField;
		}
		set
		{
			_003CLens_003Ek__BackingField = value;
		}
	}

	public Vector3 ReferenceUp
	{
		get
		{
			return _003CReferenceUp_003Ek__BackingField;
		}
		set
		{
			_003CReferenceUp_003Ek__BackingField = value;
		}
	}

	public Vector3 ReferenceLookAt
	{
		get
		{
			return _003CReferenceLookAt_003Ek__BackingField;
		}
		set
		{
			_003CReferenceLookAt_003Ek__BackingField = value;
		}
	}

	public bool HasLookAt => false;

	public Vector3 RawPosition
	{
		get
		{
			return _003CRawPosition_003Ek__BackingField;
		}
		set
		{
			_003CRawPosition_003Ek__BackingField = value;
		}
	}

	public Quaternion RawOrientation
	{
		get
		{
			return _003CRawOrientation_003Ek__BackingField;
		}
		set
		{
			_003CRawOrientation_003Ek__BackingField = value;
		}
	}

	public Vector3 PositionDampingBypass
	{
		get
		{
			return _003CPositionDampingBypass_003Ek__BackingField;
		}
		set
		{
			_003CPositionDampingBypass_003Ek__BackingField = value;
		}
	}

	public float ShotQuality
	{
		get
		{
			return _003CShotQuality_003Ek__BackingField;
		}
		set
		{
			_003CShotQuality_003Ek__BackingField = value;
		}
	}

	public Vector3 PositionCorrection
	{
		get
		{
			return _003CPositionCorrection_003Ek__BackingField;
		}
		set
		{
			_003CPositionCorrection_003Ek__BackingField = value;
		}
	}

	public Quaternion OrientationCorrection
	{
		get
		{
			return _003COrientationCorrection_003Ek__BackingField;
		}
		set
		{
			_003COrientationCorrection_003Ek__BackingField = value;
		}
	}

	public Vector3 CorrectedPosition => default(Vector3);

	public Quaternion CorrectedOrientation => default(Quaternion);

	public Vector3 FinalPosition => default(Vector3);

	public Quaternion FinalOrientation => default(Quaternion);

	public BlendHintValue BlendHint
	{
		get
		{
			return _003CBlendHint_003Ek__BackingField;
		}
		set
		{
			_003CBlendHint_003Ek__BackingField = value;
		}
	}

	public static CameraState Default => default(CameraState);

	public int NumCustomBlendables
	{
		get
		{
			return _003CNumCustomBlendables_003Ek__BackingField;
		}
		private set
		{
			_003CNumCustomBlendables_003Ek__BackingField = value;
		}
	}

	public CustomBlendable GetCustomBlendable(int index)
	{
		return null;
	}

	private int FindCustomBlendable(Object custom)
	{
		return 0;
	}

	public void AddCustomBlendable(CustomBlendable b)
	{
	}

	public static CameraState Lerp(CameraState stateA, CameraState stateB, float t)
	{
		return default(CameraState);
	}

	private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
	{
		return 0f;
	}

	private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended)
	{
		return default(Vector3);
	}

	private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended)
	{
		return default(Quaternion);
	}

	private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t)
	{
		return default(Vector3);
	}
}
