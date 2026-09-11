using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public static class UGCCoreFunc
{
	public const uint TypeCheckLegalityLevel_None = 0u;

	public const uint TypeCheckLegalityLevel_AntiHack = 1u;

	public const uint TypeCheckLegalityLevel_ValueTypeProtect = 2u;

	public const uint TypeCheckLegalityLevel_TypeMatch = 4u;

	public static object UGCNormalizeValue(UGCRuntime ugcRuntime, object valueInterface)
	{
		return null;
	}

	public static Tuple2<bool, bool> UGCTryConvertBoolByInterface(UGCRuntime ugcRuntime, object boolInterface)
	{
		return default(Tuple2<bool, bool>);
	}

	public static bool UGCConvertBoolByInterface(UGCRuntime ugcRuntime, object boolInterface)
	{
		return false;
	}

	public static Tuple2<int, bool> UGCTryConvertIntByInterface(UGCRuntime ugcRuntime, object numInterface)
	{
		return default(Tuple2<int, bool>);
	}

	public static Tuple2<long, bool> UGCTryConvertInt64ByInterface(UGCRuntime ugcRuntime, object numInterface)
	{
		return default(Tuple2<long, bool>);
	}

	public static int UGCConvertIntByInterface(UGCRuntime ugcRuntime, object numInterface)
	{
		return 0;
	}

	public static long UGCConvertInt64ByInterface(UGCRuntime ugcRuntime, object numInterface)
	{
		return 0L;
	}

	public static Tuple2<float, bool> UGCTryConvertFloatByInterface(UGCRuntime ugcRuntime, object numInterface)
	{
		return default(Tuple2<float, bool>);
	}

	public static float UGCConvertFloatByInterface(UGCRuntime ugcRuntime, object numInterface)
	{
		return 0f;
	}

	public static Tuple2<string, bool> UGCTryConvertStringByInterface(UGCRuntime ugcRuntime, object strInterface)
	{
		return default(Tuple2<string, bool>);
	}

	public static string UGCConvertStringByInterface(UGCRuntime ugcRuntime, object strInterface)
	{
		return null;
	}

	public static Tuple2<Vector3, bool> UGCTryConvertVector3ByInterface(UGCRuntime ugcRuntime, object vector3Interface)
	{
		return default(Tuple2<Vector3, bool>);
	}

	public static Vector3 UGCConvertVector3ByInterface(UGCRuntime ugcRuntime, object vector3Interface)
	{
		return default(Vector3);
	}

	public static Tuple2<Vector2, bool> UGCTryConvertVector2ByInterface(UGCRuntime ugcRuntime, object vector2Interface)
	{
		return default(Tuple2<Vector2, bool>);
	}

	public static Vector2 UGCConvertVector2ByInterface(UGCRuntime ugcRuntime, object vector2Interface)
	{
		return default(Vector2);
	}

	public static Tuple2<Quaternion, bool> UGCTryConvertQuaternionByInterface(UGCRuntime ugcRuntime, object quaternionInterface)
	{
		return default(Tuple2<Quaternion, bool>);
	}

	public static Quaternion UGCConvertQuaternionByInterface(UGCRuntime ugcRuntime, object quaternionInterface)
	{
		return default(Quaternion);
	}

	public static List<object> UGCConvertListByInterface(UGCRuntime ugcRuntime, object listInterface)
	{
		return null;
	}

	public static SimpleMap UGCConvertMapByInterface(UGCRuntime ugcRuntime, object mapInterface)
	{
		return null;
	}

	public static Tuple2<UGCLogicEntity, bool> UGCTryConvertEntityByInterface(UGCRuntime ugcRuntime, object entityInterface)
	{
		return default(Tuple2<UGCLogicEntity, bool>);
	}

	public static UGCLogicEntity UGCConvertEntityByInterface(UGCRuntime ugcRuntime, object entityInterface)
	{
		return null;
	}

	public static Dictionary<object, object> UGCGetConstMapValue(IJHPDKODECM mapValue, UGCRuntime runtime)
	{
		return null;
	}

	public static object UGCGetConstValueByVarValueData(UGCVarValueDataV2 varValueData, UGCRuntime ugcRuntime, bool fromRuntime = true)
	{
		return null;
	}

	public static bool UGCGetConstValueByVarValueDataNoGC(UGCVarValueDataV2 varValueData, UGCRuntime ugcRuntime, ref IUGCValue outValue)
	{
		return false;
	}

	public static bool UGCValueEqual(object left, object right)
	{
		return false;
	}

	public static bool CanAssignByBool(UGCRuntime runtime, MHJLOKOOGNB expectType, string varName = "")
	{
		return false;
	}

	public static bool CanAssignByInt(UGCRuntime runtime, MHJLOKOOGNB expectType, string varName = "")
	{
		return false;
	}

	public static bool CanAssignByInt64(UGCRuntime runtime, MHJLOKOOGNB expectType, string varNameOrType = "")
	{
		return false;
	}

	public static bool CanAssignByFloat(UGCRuntime runtime, MHJLOKOOGNB expectType, string varNameOrType = "")
	{
		return false;
	}

	public static bool CanAssignByVec3(UGCRuntime runtime, MHJLOKOOGNB expectType, string varNameOrType = "")
	{
		return false;
	}

	public static bool CanAssignByVec2(UGCRuntime runtime, MHJLOKOOGNB expectType, string varNameOrType = "")
	{
		return false;
	}

	public static bool CanAssignByQaternion(UGCRuntime runtime, MHJLOKOOGNB expectType, string varNameOrType = "")
	{
		return false;
	}

	private static object ValueTypeLegalityProtection(UGCRuntime ugcRuntime, MHJLOKOOGNB expectType, object targetValue)
	{
		return null;
	}

	public static Tuple2<object, bool> UGCAssignmentOperatorCheck(UGCRuntime ugcRuntime, long tempType, object targetValue, uint options)
	{
		return default(Tuple2<object, bool>);
	}

	public static MHJLOKOOGNB UGCGetValueReflectType(object value)
	{
		return MHJLOKOOGNB.Object;
	}

	public static string UGCGetStringByDataOrigin(object value, PropValueChangeOriginType orginType)
	{
		return null;
	}

	public static int UGCGetIntByDataOrigin(object value, PropValueChangeOriginType orginType)
	{
		return 0;
	}

	public static IEnumerable UGCGetListByDataOrigin(object value, PropValueChangeOriginType orginType)
	{
		return null;
	}
}
