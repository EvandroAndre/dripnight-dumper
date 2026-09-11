using System;
using System.IO;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class GrassCell : BaseCustomSerializedObject
{
	public GrassSubCell[] m_subCells;

	public Vector3 m_position;

	public bool m_hassGrass;

	public GrassCell()
	{
	}

	public GrassCell(Vector3 pos)
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
