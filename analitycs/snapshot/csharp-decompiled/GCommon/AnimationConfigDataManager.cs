using System.Collections.Generic;

namespace GCommon;

internal class AnimationConfigDataManager : SingletonModule<AnimationConfigDataManager>
{
	private Dictionary<int, AnimationConfigData> m_AnimConfigDatas;

	private Dictionary<long, AnimationBlendConfigData> m_AnimBlendConfigDatas;

	private Dictionary<string, AnimationConfigData> m_StateConfigDict;

	public Dictionary<string, AnimationConfigData> m_AnimAliasConfigDict;

	public Dictionary<int, AnimationConfigData> AnimConfigDatas => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public AnimationBlendConfigData GetAnimBlendConfigData(AnimationID fadeOut, AnimationID fadeIn)
	{
		return null;
	}

	public AnimationConfigData GetAnimConfigData(int id)
	{
		return null;
	}

	public AnimationConfigData GetAnimConfigByState(string stateName)
	{
		return null;
	}

	public AnimationConfigData GetAnimConfigByAlias(string alias)
	{
		return null;
	}
}
