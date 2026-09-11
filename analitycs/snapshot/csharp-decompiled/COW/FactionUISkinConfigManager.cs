using GCommon;
using UnityEngine;

namespace COW;

public class FactionUISkinConfigManager : SingletonModule<FactionUISkinConfigManager>
{
	private CSVAsyncDataMap<uint, FactionUISkinData> m_FactionUISkinDataDict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public FactionUISkinData GetFactionUISkinData(uint gameMode, uint matchMode)
	{
		return null;
	}

	public bool ShouldChangeHeadPic(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool IsCSPeakFenceConfigured()
	{
		return false;
	}

	public ResourceID GetCSPeakTeamFenceRes(uint teamIndex)
	{
		return default(ResourceID);
	}

	public Color GetColorByStringWithDefault(string colorString, Color defaultColor)
	{
		return default(Color);
	}

	public void SetColorByString(UISprite sprite, string colorString, uint type)
	{
	}

	public void SetColorByString(UITexture sprite, string colorString, uint type)
	{
	}

	public void SetColorByString(ParticleSystem particleSystem, string colorString)
	{
	}
}
