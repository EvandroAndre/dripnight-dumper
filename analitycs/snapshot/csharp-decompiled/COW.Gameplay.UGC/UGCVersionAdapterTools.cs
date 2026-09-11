using System;
using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public static class UGCVersionAdapterTools
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<LJICFKFGFHL> _003C_003E9__12_0;

		internal bool _003CModeSettingV3ToV4_003Eb__12_0(LJICFKFGFHL e)
		{
			return false;
		}
	}

	public static OHCGHBFNOFA UGCWorkflowDataLevelParamsAdapter(OHCGHBFNOFA newWorkflowData, Dictionary<string, object> gameParams)
	{
		return null;
	}

	public static OHCGHBFNOFA UGCWorkflowDataV0ToV1(OHCGHBFNOFA oldWorkflowData, Dictionary<string, object> gameParams)
	{
		return null;
	}

	public static OHCGHBFNOFA UGCWorkflowDataV1ToV2(OHCGHBFNOFA oldWorkflowData, Dictionary<string, object> gameParams)
	{
		return null;
	}

	public static GKGNPJEOEGP UGCGraphDataV2ToV3(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV2ToV3(List<LHPJOHPNFPJ> rules)
	{
	}

	public static LPAHANBIOKC ConvertAllSceneDataFromV0(CMPMHCMIMBI oldMap, uint mapID)
	{
		return null;
	}

	public static void ConvertSceneObjectListV0V1(OMGAPOAPGBO newVerLevelRes, CMPMHCMIMBI oldMap, float gridHalfWidth100)
	{
	}

	public static float GetRotationYawByDiretion(uint direction, uint freeDirection)
	{
		return 0f;
	}

	public static FICHBIFMBOF UGCHudPrefabDataV2ToV3(FICHBIFMBOF oldHudPrefabData)
	{
		return null;
	}

	public static void UGCHudPrefabDatasPrefabParamsAdapter(List<LBHDMMIEANP> children)
	{
	}

	public static void UGCHudPrefabDataSizeParamsAdapter(MGGLBAIOFFM widget)
	{
	}

	public static CLMPMGMIDGD ModeSettingV2ToV3(CLMPMGMIDGD oldData)
	{
		return null;
	}

	public static CLMPMGMIDGD ModeSettingV3ToV4(CLMPMGMIDGD oldData)
	{
		return null;
	}

	public static CLMPMGMIDGD ModeSettingV6ToV7(CLMPMGMIDGD oldData)
	{
		return null;
	}

	public static void SetPrivateProperty<T>(List<T> targetData, List<T> sourceData)
	{
	}

	public static GKGNPJEOEGP UGCGraphDataV3ToV4(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV3ToV4(List<LHPJOHPNFPJ> rules)
	{
	}

	public static void UGCFuncCallerDataV3ToV4(List<DOMDODOIOBI> oldFuncCallerData)
	{
	}

	public static void AdaptSetter(DOMDODOIOBI oldFuncCallerData)
	{
	}

	public static GKGNPJEOEGP UGCGraphDataV4ToV5(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV4ToV5(List<LHPJOHPNFPJ> rules)
	{
	}

	public static void UGCFuncCallerDataV4ToV5(List<DOMDODOIOBI> oldFuncCallerData)
	{
	}

	public static bool CheckEntityDataHasName(long PropID)
	{
		return false;
	}

	public static PLMKOPJMIEP UGCLogicEntityDataV5ToV6(PLMKOPJMIEP oldLogicEntityData)
	{
		return null;
	}

	public static GKGNPJEOEGP UGCGraphDataV5ToV6(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV5ToV6(List<LHPJOHPNFPJ> rules)
	{
	}

	public static void UGCFuncCallerDataV5ToV6(List<DOMDODOIOBI> oldFuncCallerData)
	{
	}

	public static GKGNPJEOEGP UGCGraphDataV6ToV7(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV6ToV7(List<LHPJOHPNFPJ> rules)
	{
	}

	public static void UGCFuncCallerDataV6ToV7(List<DOMDODOIOBI> oldFuncCallerData)
	{
	}

	public static void UGCCustomReplicationDataV7ToV8(List<FJOPMIJBFEI> oldData)
	{
	}

	public static void UGCCustomTypeTreeV7ToV8(JOEANMPIFAB oldData)
	{
	}

	public static CLMPMGMIDGD ModeSettingV7ToV8(CLMPMGMIDGD oldData)
	{
		return null;
	}

	public static CLMPMGMIDGD ModeSettingV12ToV13(CLMPMGMIDGD oldData)
	{
		return null;
	}

	public static CLMPMGMIDGD ModeSettingV14ToV15(CLMPMGMIDGD oldData)
	{
		return null;
	}

	public static void UGCStropShelfEntityDataV15ToV16(JOEANMPIFAB oldData)
	{
	}

	private static bool CheckEntityHasComponent(PLMKOPJMIEP entityData, long componentID)
	{
		return false;
	}

	private static void UpgradeStropShelfRepDataV15ToV16(PLMKOPJMIEP entityData)
	{
	}

	private static void TryAppendStropShelfVector3(List<IPIFNFDIIKK> repDataItems, long propID, string value)
	{
	}

	private static bool TryParseLegacyStropShelfVector3(string value, out Vector3 vec)
	{
		vec = default(Vector3);
		return false;
	}

	public static void UGCLogicEntityV7ToV8(JOEANMPIFAB oldData)
	{
	}

	public static void UGCLogicEntityV8ToV9(JOEANMPIFAB oldData)
	{
	}

	public static GKGNPJEOEGP UGCGraphDataV8ToV9(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV8ToV9(List<LHPJOHPNFPJ> rules)
	{
	}

	public static void UGCFuncCallerDataV8ToV9(List<DOMDODOIOBI> oldFuncCallerData)
	{
	}

	public static GKGNPJEOEGP UGCGraphDataV9ToV10(GKGNPJEOEGP oldGraphData)
	{
		return null;
	}

	public static void UGCRulesDataV9ToV10(List<LHPJOHPNFPJ> rules)
	{
	}
}
