using System;
using UnityEngine;

namespace GCommon;

public static class MathUnity
{
	public const float EPSILON = 1E-05f;

	public const float RAD0 = 0f;

	public const float RADHALF = (float)Math.PI / 360f;

	public const float RAD1 = (float)Math.PI / 180f;

	public const float RAD5 = 0.08726646f;

	public const float RAD10 = 0.17453292f;

	public const float RAD15 = (float)Math.PI / 12f;

	public const float RAD22HALF = (float)Math.PI / 8f;

	public const float RAD30 = (float)Math.PI / 6f;

	public const float RAD45 = (float)Math.PI / 4f;

	public const float RAD60 = (float)Math.PI / 3f;

	public const float RAD90 = (float)Math.PI / 2f;

	public const float RAD120 = (float)Math.PI * 2f / 3f;

	public const float RAD135 = (float)Math.PI * 3f / 4f;

	public const float RAD180 = (float)Math.PI;

	public static readonly float FarDistance;

	public static Matrix4x4 matrixCaculation;

	public static Vector3 Vector3_0;

	public static Vector3 Vector3_X;

	public static Vector3 Vector3_Y;

	public static Vector3 Vector3_Z;

	public static Vector3 Vector3_NX;

	public static Vector3 Vector3_NY;

	public static Vector3 Vector3_NZ;

	public static bool IsValid(Vector3 v)
	{
		return false;
	}

	public static bool IsValid(Quaternion q)
	{
		return false;
	}

	public static Vector3 TrimNaN(Vector3 self)
	{
		return default(Vector3);
	}

	public static Quaternion TrimNaN(Quaternion self)
	{
		return default(Quaternion);
	}

	public static Vector3 Vector3ZeroY(Vector3 v)
	{
		return default(Vector3);
	}

	public static Vector3 VectorWithY(Vector3 v, float y)
	{
		return default(Vector3);
	}

	public static Vector3 GetDirection2D(Vector3 to, Vector3 from)
	{
		return default(Vector3);
	}

	public static Vector3 GetDirection(Vector3 to, Vector3 from)
	{
		return default(Vector3);
	}

	public static float GetDistance2D(Vector3 to, Vector3 from)
	{
		return 0f;
	}

	public static float GetDistance2DSqr(Vector3 to, Vector3 from)
	{
		return 0f;
	}

	public static float GetDistance(Vector3 to, Vector3 from)
	{
		return 0f;
	}

	public static float AngleBetween2DWithSign(Vector3 from, Vector3 to)
	{
		return 0f;
	}

	public static bool IsZero(float v, float e = 1E-05f)
	{
		return false;
	}

	public static bool IsZero(Vector3 v, float e = 1E-05f)
	{
		return false;
	}

	public static bool IsEqual(float v1, float v2, float e = 1E-05f)
	{
		return false;
	}

	public static Vector3 GetReflectedVector(Vector3 v, Vector3 n)
	{
		return default(Vector3);
	}

	public static float GetFraction(float v)
	{
		return 0f;
	}

	public static Vector3 RotateVectorAroundY(Vector3 v, float angle)
	{
		return default(Vector3);
	}

	public static Vector3 AngleToVector2D(float angle)
	{
		return default(Vector3);
	}

	public static float Vector2DToAngle(Vector3 v)
	{
		return 0f;
	}

	public static float NormalizeAngleZeroToTowPI(float angle)
	{
		return 0f;
	}

	public static float NormalizeAngleNegPIToPI(float angle)
	{
		return 0f;
	}

	public static Vector3 TransformDirection(Vector3 f, Vector3 d)
	{
		return default(Vector3);
	}

	public static Vector3 TransformPoint(Vector3 f, Vector3 basep, Vector3 p)
	{
		return default(Vector3);
	}

	public static float GetSign(float v)
	{
		return 0f;
	}

	public static bool CheckVector3Equals(Vector3 vec1, Vector3 vec2)
	{
		return false;
	}

	public static bool CheckVector3Equals(Vector3 vec1, Vector3 vec2, float e)
	{
		return false;
	}

	public static bool Approximately(Vector3 self, Vector3 other, float e = 1E-05f)
	{
		return false;
	}

	public static bool ApproximatelyXY(Vector3 self, Vector3 other, float e = 1E-05f)
	{
		return false;
	}

	public static bool IsInRange(Vector3 self, Vector3 min, Vector3 max)
	{
		return false;
	}

	public static bool CheckQuaternionEquals(Quaternion q1, Quaternion q2, float e = 1E-05f)
	{
		return false;
	}

	public static Vector3 Get2BezeirPoint(Vector3 P0, Vector3 P1, Vector3 P2, float t)
	{
		return default(Vector3);
	}

	public static Quaternion LookRotation(Vector3 forward)
	{
		return default(Quaternion);
	}

	public static Quaternion LookRotation(Vector3 forward, Vector3 up)
	{
		return default(Quaternion);
	}

	public static float RoundTo(float raw, uint precision)
	{
		return 0f;
	}

	public static Vector3 RoundVector3F2(Vector3 raw)
	{
		return default(Vector3);
	}

	public static Vector3 RoundVector3(Vector3 raw, uint precision)
	{
		return default(Vector3);
	}

	public static Quaternion ToQuaternion(Vector4 v)
	{
		return default(Quaternion);
	}

	public static Vector4 ToVector4(Quaternion q)
	{
		return default(Vector4);
	}

	public static float HorizontalSqrMagnitude(Vector3 self)
	{
		return 0f;
	}

	public static bool HorizontalEqual(Vector3 self, Vector3 other, float e = 1E-05f)
	{
		return false;
	}

	public static bool WorldPosIsInCamera(Vector3 self, Camera camera)
	{
		return false;
	}

	public static Vector2? WorldPosToUIPos(Vector3 self, Camera worldCamera, Camera uiCamera)
	{
		return null;
	}

	public static bool Approximately(float self, float targetValue, float e = 1E-05f)
	{
		return false;
	}

	public static float SafeDivision(float self, float value, float? returnValueWhenNotSafe = null)
	{
		return 0f;
	}

	public static Vector3 SetYZero(Vector3 self)
	{
		return default(Vector3);
	}

	public static Vector3 AddY(Vector3 self, float y)
	{
		return default(Vector3);
	}

	public static Vector3 AddZ(Vector3 self, float z, bool roundAsAngle = false)
	{
		return default(Vector3);
	}

	public static Vector3 SetXZ(Vector3 self, float x, float z)
	{
		return default(Vector3);
	}

	public static Vector3 SetZ(Vector3 self, float z)
	{
		return default(Vector3);
	}
}
