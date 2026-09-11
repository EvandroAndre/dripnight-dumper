using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

public class UGCRockSystem : MonoBehaviour
{
	public class RockDistributionData : BaseCustomSerializedObject
	{
		public int m_meshID;

		public Vector3 m_position;

		public Vector3 m_scale;

		public Quaternion m_rotation;

		protected override void OnJsonRead(JsonData json_data)
		{
		}

		protected override void OnJsonWrite(ref JsonWriter writer)
		{
		}

		protected override void OnBinaryRead(ref BinaryReader reader)
		{
		}

		protected override void OnBinaryWrite(ref BinaryWriter writer)
		{
		}

		public void _003C_003EiFixBaseProxy_OnBinaryRead(ref BinaryReader P0)
		{
		}

		public void _003C_003EiFixBaseProxy_OnBinaryWrite(ref BinaryWriter P0)
		{
		}
	}

	public List<GameObject> m_RockTypes;

	private Dictionary<string, List<GameObject>> m_SceneRocks;

	private Dictionary<string, List<RockDistributionData>> m_SceneRockDistributionDatas;

	private List<GameObject> Rocks;

	private List<GameObject> RockInst;

	private List<GameObject> buildRockMesh(string sceneID)
	{
		return null;
	}

	public bool LoadFERockData(string sceneid, byte[] data)
	{
		return false;
	}

	private bool LoadFERockDataNew_i(string sceneid, byte[] data)
	{
		return false;
	}

	public void ReleaseFERockData(string sceneid)
	{
	}
}
