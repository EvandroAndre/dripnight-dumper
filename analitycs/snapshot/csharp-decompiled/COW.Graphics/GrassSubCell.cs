using System;
using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class GrassSubCell : BaseCustomSerializedObject
{
	public List<int> m_grassList;

	public List<int> m_bushList;

	public Vector3 m_position;

	public int m_vertCount;

	public bool m_hassGrass;

	[NonSerialized]
	public int m_updateCount;

	public GrassSubCell()
	{
	}

	public GrassSubCell(Vector3 pos, int vertCount = 0)
	{
	}

	protected override void OnBinaryRead(ref BinaryReader reader)
	{
	}

	protected override void OnBinaryWrite(ref BinaryWriter writer)
	{
	}

	protected override void OnJsonRead(JsonData json_data)
	{
	}

	protected override void OnJsonWrite(ref JsonWriter writer)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBinaryRead(ref BinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBinaryWrite(ref BinaryWriter P0)
	{
	}
}
