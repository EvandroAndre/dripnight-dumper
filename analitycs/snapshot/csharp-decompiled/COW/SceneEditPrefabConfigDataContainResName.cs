namespace COW;

public class SceneEditPrefabConfigDataContainResName : SceneEditPrefabConfigData
{
	public string PrefabResName;

	public string ShadowResName;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public new void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
