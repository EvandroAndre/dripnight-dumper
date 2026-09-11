using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

[Serializable]
public class FullHDAnimOverrideCtrlConfig : ScriptableObject
{
	private sealed class BaseControllerOverridesCacheEntry
	{
		public List<KeyValuePair<AnimationClip, AnimationClip>> Pairs;

		public List<string> BaseClipNames;
	}

	public string CtrlName;

	public string baseControllerRes;

	public List<string> names;

	public List<AnimationClip> clips;

	private Dictionary<string, AnimationClip> Name2ClipDic;

	private AnimatorOverrideController ctrlCache;

	private static Dictionary<string, BaseControllerOverridesCacheEntry> s_CachedBaseClips;

	private static List<KeyValuePair<AnimationClip, AnimationClip>> s_TmpClips;

	public static void ReleaseStaticResources()
	{
	}

	public AnimatorOverrideController GetAnimatorOverrideCtrl()
	{
		return null;
	}

	private List<KeyValuePair<AnimationClip, AnimationClip>> GetClipsToOverride(AnimatorOverrideController overrideCtrl)
	{
		return null;
	}

	private void GetClipsToOverrideCached(AnimatorOverrideController overrideCtrl, List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
	{
	}
}
