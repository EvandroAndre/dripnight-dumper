using System;
using System.Collections.Generic;

namespace ReactUI;

[Serializable]
public sealed class UIMapVariable
{
	[Serializable]
	public class MapKV
	{
		public bool BoolKey;

		public bool BoolValue;

		public int IntKey;

		public int IntValue;

		public float FloatKey;

		public float FloatValue;

		public string StringKey;

		public string StringValue;
	}

	private int srcVarIdx;

	private UIVariable outVariable;

	public List<MapKV> map;

	private UIVariable srcVariable;

	public UIVariable OutVariable => null;

	public bool IsValid => false;

	public UIVariableType SrcType => UIVariableType.Boolean;

	public void SetSrcVariable(UIVariableTable variableTable, int srcIdx)
	{
	}

	public void Init(UIVariableTable variableTable)
	{
	}

	public void BindEvent()
	{
	}

	public void UnBindEvent()
	{
	}

	public void UpdateValues()
	{
	}

	private void MapSrcValueBoolean(bool srcVal)
	{
	}

	private void MapSrcValueInt(int srcVal)
	{
	}

	private void MapSrcValueFloat(float srcVal)
	{
	}

	private void MapSrcValueString(string srcVal)
	{
	}

	private void SetOutVariable(MapKV _map)
	{
	}
}
