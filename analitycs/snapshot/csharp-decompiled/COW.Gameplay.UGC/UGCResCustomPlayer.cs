using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResCustomPlayer : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public LMGMKHOHBCF replaceClip;

		public UGCResCustomPlayer _003C_003E4__this;

		internal void _003CLoadFromData_003Eb__1(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	protected HMBABKEOFIJ m_resPlayerData;

	protected UGCResOneAvatar m_avatarRes;

	protected Dictionary<string, Dictionary<string, UGCResAnimationClip>> m_animations;

	protected Dictionary<string, Dictionary<string, UGCResAnimationClip>> m_animationsFemale;

	private UGCResAnimationClip m_disableAnimationClip;

	private UGCResAnimationClip m_idleAnimationClip;

	public Dictionary<string, Dictionary<string, UGCResAnimationClip>> ReplaceAnimations => null;

	public Dictionary<string, Dictionary<string, UGCResAnimationClip>> ReplaceAnimationsFemale => null;

	public UGCResOneAvatar AvatarRes => null;

	public float Scale => 0f;

	public string PrefabID => null;

	public bool IsCustomFemale => false;

	public NKNFNFMOFJM OverrideAnimCtrlsConfig => null;

	public bool IsDisableOtherAnimation => false;

	public UGCResAnimationClip DisableAnimationClip => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	protected override void AfterOneDependLoaded()
	{
	}

	private void ApplyAliasAnimations(bool isFemale)
	{
	}

	private void InitAnimationDictionary()
	{
	}

	private bool IsLoopedAnimation(string animName)
	{
		return false;
	}

	private void AddAnimationClip(string animType, string animName, UGCResAnimationClip clip)
	{
	}

	private void addToAnimationMap(string animType, string animName, UGCResAnimationClip clip, Dictionary<string, Dictionary<string, UGCResAnimationClip>> animMap)
	{
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void _003CLoadFromData_003Eb__24_0(bool succ, UGCResOneAvatar resObj)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_AfterOneDependLoaded()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}
}
