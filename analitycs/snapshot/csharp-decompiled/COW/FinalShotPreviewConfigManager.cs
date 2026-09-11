using System.Collections.Generic;
using GCommon;

namespace COW;

public class FinalShotPreviewConfigManager : SingletonModule<FinalShotPreviewConfigManager>
{
	private const uint DefaultFinalShot = 0u;

	private Dictionary<uint, Dictionary<uint, FinalShotPreviewConfig>> m_DicFinalShotPreviewConfig;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public FinalShotPreviewConfig GetConfigByPreviewTypeAndFinalShotId(FrontendPreviewType type, uint fianlShotId)
	{
		return null;
	}
}
