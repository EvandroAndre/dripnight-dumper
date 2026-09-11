using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public static class Utils
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public int argIndex;

		internal string _003CConvertGoFormatToCSharp_003Eb__0(Match match)
		{
			return null;
		}
	}

	private const string LOC_STRING_V2 = "@LOC_STRING_V2";

	public static void PCall(StackContext stackContext)
	{
	}

	public static string GetCallStackToString(string runningCodeID, StackContext stackContext)
	{
		return null;
	}

	public static void InvokeAPI(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static bool InvokeCmd(DOMDODOIOBI target, StackContext stackContext)
	{
		return false;
	}

	public static UGCSimpleValue InvokeCmd_Variable(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static void InvokeCmd_WaitForNextFrame(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_WaitForSeconds(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_WaitForCondition(WaitForConditionFunc conditionFunc, StackContext stackContext)
	{
	}

	public static void InvokeCmd_CodeBlock(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_Branch(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static bool IsEmptyLoop(int start, int end, int step)
	{
		return false;
	}

	public static void InvokeCmd_ForIndex(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_ForLoopRange(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_While(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_Return(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_Break(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_Continue(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static bool ValueEqual(object left, object right)
	{
		return false;
	}

	public static void InvokeCmd_CompareOp(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_ArithmeticOp(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void ArithmeticOp(UGCSimpleValue leftCoreValue, UGCSimpleValue rightCoreValue, JJMDKFLEJND arithmeticType, StackContext stackContext)
	{
	}

	public static int ArithmeticOpInt(int leftInt, int rightInt, JJMDKFLEJND arithmeticType, StackContext stackContext)
	{
		return 0;
	}

	public static float ArithmeticOpFloat(float left, float right, JJMDKFLEJND arithmeticType, StackContext stackContext)
	{
		return 0f;
	}

	public static string UGCSafeValue2String(object value)
	{
		return null;
	}

	public static string ValueToString(object value, bool dumpElement = false)
	{
		return null;
	}

	public static void InvokeCmd_StringConcat(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_StringFormat(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_FormatStr(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	private static string ConvertGoFormatToCSharp(string goFormat)
	{
		return null;
	}

	public static void InvokeCmd_BitwiseCommon(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_BitwiseIntToList(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_BitwiseListToInt(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_BitwiseNot(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_CallSelfFunc(bool isSyncCall, DOMDODOIOBI target, StackContext upStack)
	{
	}

	public static void InvokeCmd_CallCustomFunc(bool isSyncCall, DOMDODOIOBI target, StackContext upStack)
	{
	}

	public static void InvokeCmd_CallGlobalCustomFunc(bool isSyncCall, DOMDODOIOBI target, StackContext upStack)
	{
	}

	public static void InvokeCmd_FuncPointInvoke(bool isSyncCall, DOMDODOIOBI target, StackContext upStack)
	{
	}

	public static object GetConstValueFromData(UGCVarValueDataV2 varValueData, UGCRuntime runtime)
	{
		return null;
	}

	public static UGCSimpleValue GetConstCoreValue(UGCVarValueDataV2 varValueData, UGCSimpleValue refCoreValue, UGCRuntime runtime)
	{
		return null;
	}

	public static List<object> GetConstListValueFromData(UGCVarValueDataV2 varValueData, UGCRuntime runtime)
	{
		return null;
	}

	public static SimpleMap GetConstMapValueFromData(UGCVarValueDataV2 varValueData, UGCRuntime runtime)
	{
		return null;
	}

	public static LocString GetConstLocStringValueFromData(UGCVarValueDataV2 varValueData, UGCRuntime runtime)
	{
		return null;
	}

	public static object GetConstFuncPointValueFromData(UGCVarValueDataV2 varValueData)
	{
		return null;
	}

	public static Quaternion GetConstQuaValueFromData(UGCVarValueDataV2 varValueData)
	{
		return default(Quaternion);
	}

	public static Vector3 GetConstVec3ValueFromData(UGCVarValueDataV2 varValueData)
	{
		return default(Vector3);
	}

	public static Vector2 GetConstVec2ValueFromData(UGCVarValueDataV2 varValueData)
	{
		return default(Vector2);
	}

	public static object GetConstEntityRefValueFromData(UGCVarValueDataV2 varValueData, UGCRuntime runtime)
	{
		return null;
	}

	public static object GetVarInterfaceValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static LocString GetLocStringFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static UGCSimpleValue GetVarCoreValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static List<object> GetListValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static int ConvertListToLayerMask(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return 0;
	}

	public static bool[] GetConditionArrayValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static List<object> ConvertListByInterface(object listInterface)
	{
		return null;
	}

	public static SimpleMap GetMapValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static bool GetBoolValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return false;
	}

	public static int GetIntValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return 0;
	}

	public static long GetInt64ValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return 0L;
	}

	public static float GetFloatValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return 0f;
	}

	public static double GetDoubleValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return 0.0;
	}

	public static string GetStringValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static UGCLogicEntity GetEntityValueFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static FuncPoint GetFuncPointFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static Quaternion GetQuaternionFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return default(Quaternion);
	}

	public static Vector3 GetVec3FromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return default(Vector3);
	}

	public static Vector2 GetVec2FromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return default(Vector2);
	}

	public static Vector2 ConvertVector2ByInterface(object vector2Interface)
	{
		return default(Vector2);
	}

	public static DirectedPoint GetDirectPointFromData(UGCVarValueDataV2 varValueData, StackContext stackContext)
	{
		return null;
	}

	public static void InvokeCmd_DefStackVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_GetStackVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_GetStackVarByIndex(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_SetStackVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_SetStackVarByIndex(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_GetScriptVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_GetSelfScriptVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_SetScriptVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}

	public static void InvokeCmd_SetSelfScriptVar(DOMDODOIOBI target, StackContext stackContext)
	{
	}
}
