using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResAnimationController : UGCResource
{
	private JBDFMDFACGC m_resData;

	private UGCResBodyPartDef m_bodyPartDef;

	private List<IHFBKHILNCA> m_bodyPartDataList;

	private List<UGCResAnimationClip> m_dependAnimation;

	private Dictionary<string, UGCResAnimationClip> m_nameOrUUID2AnimationClip;

	private Dictionary<string, UGCResAnimationClip> m_usedName2AnimationClip;

	private Dictionary<string, UGCResAnimationClip> m_blendTreeOverrideAnimationClips;

	public JBDFMDFACGC ResData => null;

	public UGCResBodyPartDef BodyPartDef => null;

	public List<IHFBKHILNCA> BodyPartDataList => null;

	public Dictionary<string, UGCResAnimationClip> BlendTreeOverrideAnimationClips => null;

	public bool IsSupportAnimation => false;

	public bool IsSupportAnimator => false;

	private void validateBodyPartList()
	{
	}

	private void ClearOtherResDependence()
	{
	}

	public UGCResAnimationClip GetClipByName(string name)
	{
		return null;
	}

	public UGCResAnimationClip GetClipByUUID(string uuid)
	{
		return null;
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	private void fixClipLocalStartTimeForOldVersion()
	{
	}

	private void fixClipLocalStartTimeForOldVersion(KFMNNDOIMBG state, string bodyPartName)
	{
	}

	public void CreateAsEmpty()
	{
	}

	private void OnAnimationChanged(UGCResource res)
	{
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void LoadAnimationClip()
	{
	}

	public void SetupAnimation(UGCAnimPlayable_Simple animation)
	{
	}

	public void SetupAnimation(Animation animation)
	{
	}

	private void _003CLoadFromData_003Eb__19_0(bool succ, UGCResBodyPartDef resObj)
	{
	}

	private void _003CLoadAnimationClip_003Eb__25_0(bool succ, UGCResAnimationClip resObj)
	{
	}

	private void _003CLoadAnimationClip_003Eb__25_1(bool succ, UGCResAnimationClip resObj)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}
}
