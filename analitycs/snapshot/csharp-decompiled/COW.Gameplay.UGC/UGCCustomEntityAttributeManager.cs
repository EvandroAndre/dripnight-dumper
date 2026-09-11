using System;
using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCCustomEntityAttributeManager : MonoSingleton<UGCCustomEntityAttributeManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<IPIFNFDIIKK> _003C_003E9__13_0;

		internal bool _003CClearCustomRepData_003Eb__13_0(IPIFNFDIIKK e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public long propID;

		internal bool _003CGetAttributeNameByPropID_003Eb__0(IBILCDHHNHM e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public INAMDLOFOHF data;

		public AOKBGKNKKLJ typeEntity;
	}

	private sealed class _003C_003Ec__DisplayClass33_1
	{
		public int i;

		public _003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals1;

		internal bool _003CModifyCustomRepData_003Eb__0(IBILCDHHNHM e)
		{
			return false;
		}

		internal bool _003CModifyCustomRepData_003Eb__1(IBILCDHHNHM e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_2
	{
		public int i;

		public _003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals2;

		internal bool _003CModifyCustomRepData_003Eb__2(IPIFNFDIIKK repData)
		{
			return false;
		}
	}

	private EditorEntityData m_EditorEntityData;

	private Dictionary<string, AOKBGKNKKLJ> m_TypeEntityAttributeDic;

	public EditorEntityData EditorEntityData => null;

	public Dictionary<string, AOKBGKNKKLJ> TypeEntityAttributeDic => null;

	public override void Init()
	{
	}

	public void AfterLoadProject()
	{
	}

	public void Clean()
	{
	}

	public byte[] ToBytes()
	{
		return null;
	}

	public bool FromBytes(byte[] dataBytes, MFDKDILMLFP version)
	{
		return false;
	}

	private void Adapter()
	{
	}

	public List<FJOPMIJBFEI> ExportReplicationData()
	{
		return null;
	}

	public void ClearCustomRepData(INAMDLOFOHF data)
	{
	}

	public void SetTypeEntity(string type, AOKBGKNKKLJ data)
	{
	}

	public bool AddTypeEntity(string type)
	{
		return false;
	}

	public bool CheckNameExist(string name, AOKBGKNKKLJ customData, IBILCDHHNHM excludeData = null)
	{
		return false;
	}

	public bool HasTypeEntity(string type)
	{
		return false;
	}

	public string GetAttributeName(string type, int index)
	{
		return null;
	}

	public string GetAttributeNameByPropID(string type, long propID)
	{
		return null;
	}

	private List<IBILCDHHNHM> CopyReplicationDataItem(List<IBILCDHHNHM> data)
	{
		return null;
	}

	public AOKBGKNKKLJ GetCustomReplicatioEntityData(string type)
	{
		return null;
	}

	public AOKBGKNKKLJ GetNewCustomReplicatioEntityData(string type)
	{
		return null;
	}

	public AOKBGKNKKLJ GetNewCustomReplicatioEntityDataWithDefault(string type)
	{
		return null;
	}

	public long GenerateNewCustomVarPropId(AOKBGKNKKLJ typeEntity)
	{
		return 0L;
	}

	private List<IPIFNFDIIKK> CopyReplicationDataToInstance(AOKBGKNKKLJ typeEntity)
	{
		return null;
	}

	public bool CreateInstanceEntity(string entityType, string entityID)
	{
		return false;
	}

	public List<IPIFNFDIIKK> GetInstanceEntityCustomAttributes(string id)
	{
		return null;
	}

	public List<IPIFNFDIIKK> GetInstanceEntityCustomAttributesByEntityType(string id, string entityType)
	{
		return null;
	}

	public bool HasEntity(string id)
	{
		return false;
	}

	private UGCVarValueDataV2 GetNewVarValueData(UGCVarValueDataV2 oriData)
	{
		return null;
	}

	private UGCVarValueDataV2 CloneUGCVarValueDataV2(UGCVarValueDataV2 oriData)
	{
		return null;
	}

	public void RedefineInstanceEntityAttribute(AOKBGKNKKLJ typeEntity)
	{
	}

	private void ModifyCustomRepData(INAMDLOFOHF data, AOKBGKNKKLJ typeEntity)
	{
	}

	private bool IsBelongToEntityType(long propID, string entityType)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
