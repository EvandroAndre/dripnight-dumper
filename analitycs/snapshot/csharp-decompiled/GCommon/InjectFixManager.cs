using UnityEngine;

namespace GCommon;

public class InjectFixManager
{
	private static InjectFixManager instance;

	public bool LoadPatchFailed;

	private AssetBundle m_CodePathAB;

	public static InjectFixManager Instance => null;

	public bool Support()
	{
		return false;
	}

	public void LoadPatch(ResourceID[] codePatchResIDs)
	{
	}

	public void LoadPatch(string patchFileAb)
	{
	}

	public void LoadTestPatch()
	{
	}
}
