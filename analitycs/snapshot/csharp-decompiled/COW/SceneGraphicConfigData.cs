using System.Collections.Generic;
using GCommon;

namespace COW;

public class SceneGraphicConfigData : SingletonModule<SceneGraphicConfigData>
{
	private Dictionary<string, SceneGraphicConfigItem> m_SceneConfigDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void LoadDataFromConfig()
	{
	}

	public SceneGraphicConfigItem GetSceneGraphicConfig(string sceneName)
	{
		return null;
	}
}
