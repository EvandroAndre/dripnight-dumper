using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay;

public static class LogicEntityAttributeUtil
{
	public class LogicSetAttributeEvent : GEvent
	{
		public string LogicEntityID;

		public long PropID;

		public string Value;

		public void Reset(string id, long propid, string value)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<float, UGCVarValueDataV2> _003C_003E9__43_0;

		internal UGCVarValueDataV2 _003CSetAttributeListEntityListFloatValue_003Eb__43_0(float item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public int key;

		internal bool _003CContainsAttributeMapIntIntKey_003Eb__0(UGCVarValueDataV2 item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public int index;

		internal bool _003CInitAttributeList_003Eb__0(IPIFNFDIIKK e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public string value;

		internal bool _003CRemoveAttributeListString_003Eb__0(UGCVarValueDataV2 e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public long index;

		internal bool _003CGetAttribute_003Eb__0(IPIFNFDIIKK e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public IJHPDKODECM mapValue;

		internal void _003CTryCreateVarValueData_003Eb__0(object key, object mapItemValue)
		{
		}
	}

	public const float VectorEqualThreshold = 0.001f;

	public static LogicSetAttributeEvent LogicSetAttrEvt;

	private static StringBuilder sb;

	public static void RemoveAttribute(INAMDLOFOHF entity, long index)
	{
	}

	public static void SetAttribute(INAMDLOFOHF entity, long index, UGCVarValueDataV2 value)
	{
	}

	internal static bool TrySetAttributeEntityValueFromDataStore(INAMDLOFOHF entity, long index, UGCSimpleValue value)
	{
		return false;
	}

	private static bool TryCreateVarValueData(UGCSimpleValue value, out UGCVarValueDataV2 varValue)
	{
		varValue = null;
		return false;
	}

	private static bool TryCreateVarValueData(object value, out UGCVarValueDataV2 varValue)
	{
		varValue = null;
		return false;
	}

	private static BHHFHBEKKFJ CreateProtoBuffVector2(Vector2 value)
	{
		return null;
	}

	private static KCEOCGOLEAD CreateProtoBuffVector3(Vector3 value)
	{
		return null;
	}

	private static LGDCLLICIIC CreateProtoBuffQuaternion(Quaternion value)
	{
		return null;
	}

	public static void SetAttributeString(INAMDLOFOHF entity, long index, string value, bool needLog = true)
	{
	}

	public static string GetAttributeString(INAMDLOFOHF entity, int index)
	{
		return null;
	}

	public static void SetAttributeInt(INAMDLOFOHF entity, long index, int value, bool needLog = true)
	{
	}

	public static long GetAttributeInt64(INAMDLOFOHF entity, int index)
	{
		return 0L;
	}

	public static void SetAttributeInt64(INAMDLOFOHF entity, long index, long value, bool needLog = true)
	{
	}

	public static int GetAttributeInt(INAMDLOFOHF entity, int index)
	{
		return 0;
	}

	public static void SetAttributeFloat(INAMDLOFOHF entity, long index, float value)
	{
	}

	public static float GetAttributeFloat(INAMDLOFOHF entity, int index)
	{
		return 0f;
	}

	public static void SetAttributeBool(INAMDLOFOHF entity, long index, bool value, bool needLog = true)
	{
	}

	public static bool GetAttributeBool(INAMDLOFOHF entity, int index)
	{
		return false;
	}

	public static Vector2 GetVector2FromString(string value)
	{
		return default(Vector2);
	}

	public static bool IsUGCEquals(Vector2 v1, Vector2 v2)
	{
		return false;
	}

	public static bool IsUGCEquals(Vector3 v1, Vector3 v2)
	{
		return false;
	}

	public static string ConvertProtoBuffVector2ToString(BHHFHBEKKFJ vec)
	{
		return null;
	}

	public static void SetAttributeVector2(INAMDLOFOHF entity, long index, Vector2 value)
	{
	}

	public static Vector2 GetAttributeVector2(INAMDLOFOHF entity, int index)
	{
		return default(Vector2);
	}

	public static Vector3 GetVector3FromString(string value)
	{
		return default(Vector3);
	}

	public static Quaternion GetQuaternionFromString(string value)
	{
		return default(Quaternion);
	}

	public static string ConvertProtoBuffQuaternionToString(LGDCLLICIIC vec)
	{
		return null;
	}

	public static string ConvertProtoBuffVector3ToString(KCEOCGOLEAD vec)
	{
		return null;
	}

	public static void SetAttributeVector3(INAMDLOFOHF entity, long index, Vector3 value)
	{
	}

	public static Vector3 GetAttributeVector3(INAMDLOFOHF entity, int index)
	{
		return default(Vector3);
	}

	public static void SetAttributeQuaternion(INAMDLOFOHF entity, long index, Quaternion value)
	{
	}

	public static Quaternion GetAttributeQuaternion(INAMDLOFOHF entity, int index)
	{
		return default(Quaternion);
	}

	public static void InitAttributeMap(INAMDLOFOHF entity, int index)
	{
	}

	public static int SetAttributeMapIntIntValue(INAMDLOFOHF entity, int index, int key, int value)
	{
		return 0;
	}

	public static IJHPDKODECM GetAttributeMapIntIntValue(INAMDLOFOHF entity, int propIdx)
	{
		return null;
	}

	public static bool ContainsAttributeMapIntIntKey(INAMDLOFOHF entity, int propIdx, int key)
	{
		return false;
	}

	public static void RemoveAttributeMapIntInit(INAMDLOFOHF entity, int propIdx, int key, int mapIdx)
	{
	}

	public static void InitAttributeList(INAMDLOFOHF entity, int index)
	{
	}

	public static string GetAttributeEntityRefValue(INAMDLOFOHF entity, int index, string value)
	{
		return null;
	}

	public static void SetAttributeEntityRefValue(INAMDLOFOHF entity, long index, string value)
	{
	}

	public static void SetAttributeListEntityRefValue(INAMDLOFOHF entity, long index, string value)
	{
	}

	public static void SetAttributeListEntityIntValue(INAMDLOFOHF entity, int index, int value)
	{
	}

	public static void SetAttributeListEntityListFloatValue(INAMDLOFOHF entity, int index, List<float> value)
	{
	}

	public static void RemoveAttributeListString(INAMDLOFOHF entity, int index, string value)
	{
	}

	public static List<UGCVarValueDataV2> GetAttributeListValue(INAMDLOFOHF entity, int index)
	{
		return null;
	}

	public static IPIFNFDIIKK GetAttribute(INAMDLOFOHF entity, long index)
	{
		return null;
	}

	public static EUGCMutableValueType GetMutableValueType(MHJLOKOOGNB valueType)
	{
		return EUGCMutableValueType.None;
	}

	public static EUGCMutableValueType GetMutableValueType(string valueTypeName)
	{
		return EUGCMutableValueType.None;
	}

	public static MHJLOKOOGNB GetFinalDataValueType(string typeName)
	{
		return MHJLOKOOGNB.Object;
	}

	public static MHJLOKOOGNB GetFinalDataValueType(long propID)
	{
		return MHJLOKOOGNB.Object;
	}

	public static void SetAttributeEntityValue(INAMDLOFOHF entity, long index, string value)
	{
	}

	public static void SetAttributeEntityValue(INAMDLOFOHF entity, long index, UGCSimpleValue value)
	{
	}

	public static void SetAttributeEntityValue(INAMDLOFOHF entity, long index, MutableValue value)
	{
	}

	public static void CopyAttributeEntityValue(INAMDLOFOHF fromEntity, INAMDLOFOHF toEntity)
	{
	}

	public static string GetAttributeEntityValue(INAMDLOFOHF entity, long index)
	{
		return null;
	}

	public static string GetAttributeEntityValue(IPIFNFDIIKK data, long index)
	{
		return null;
	}

	internal static string Print(PMFGOGFPDHM v)
	{
		return null;
	}

	internal static string Print(OKEAKKNJIGH v)
	{
		return null;
	}

	internal static string Print(BJIPILEFOGL v)
	{
		return null;
	}

	internal static string Print(KPKBMOIIACM v)
	{
		return null;
	}

	internal static string Print(LHCCPONLGAK v)
	{
		return null;
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, MutableValue value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, bool value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, int value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, float value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, string value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, Vector2 value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, Vector3 value, bool autoCreateProperty = false)
	{
	}

	public static void SetRepItemToDataStore(string logicEntityID, long propID, Quaternion value, bool autoCreateProperty = false)
	{
	}
}
