using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCPlayer
{
	GameObject gameObject { get; }

	Transform BoneRootTransform { get; }

	ulong GetShowUserID();

	void PlayUGCEmoteClip(string emoteClipUUID, bool isLooping, bool overrideGamePlayControl);
}
