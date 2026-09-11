using System.Collections.Generic;
using GCommon;

namespace COW;

public class GraphicQualityConfigData : SingletonModule<GraphicQualityConfigData>
{
	private Dictionary<int, Dictionary<int, GraphicConfigItem>> m_QualityConfigDic;

	private GraphicConfigItem defaultGraphicConfigItems;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void LoadDataFromConfig()
	{
	}

	public GraphicConfigItem GetCurrentConfig()
	{
		return null;
	}
}
