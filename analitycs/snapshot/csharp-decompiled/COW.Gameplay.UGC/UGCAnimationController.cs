using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

internal class UGCAnimationController : IUGCAnimationController
{
	private class CachePlayStateInfo
	{
		public int cacheType;

		public string stateName;

		public float speed;

		public bool overrideLoop;

		public bool isLoop;

		public float currentStateSpeed;

		public bool isStateLoop;

		public string currentClipName;

		public float currentClipProgress;

		public bool isClipLoop;

		public float currentClipSpeed;
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UGCAnimationController _003C_003E4__this;

		public string resUUID;

		internal void _003CLoadControllerByResUUID_003Eb__0(bool succ, UGCResAnimationController resObj)
		{
		}
	}

	private UGCAnimationControllerSingle m_singlePlayer;

	private UGCAnimationControllerComplex m_complexPlayer;

	private UGCResAnimationController m_curRes;

	private bool m_useSingleController;

	private Animation m_cacheAnimation;

	private Animator m_cacheAnimator;

	private GameObject m_animOwnerObjSelByRes;

	private UGCPlayerBridge m_playerBridge;

	private bool m_isInited;

	private string m_cacheEntityID;

	private string m_cacheACResUUID;

	private CachePlayStateInfo m_cachePlayState;

	public UGCAnimationControllerComplex ComplexPlayer => null;

	public void SetPlayerBridge(UGCPlayerBridge playerBridge)
	{
	}

	private bool validAnimObject(GameObject animObj, out Animator animator, out Animation animation)
	{
		animator = null;
		animation = null;
		return false;
	}

	private void switchAnimationOrAnimator(GameObject animObj, bool isUseAnimator)
	{
	}

	private void tryInitImplController(bool canUseEmptyRes = false)
	{
	}

	public Animation tryGetAnimation(GameObject obj)
	{
		return null;
	}

	public Animator tryGetAnimator(GameObject obj)
	{
		return null;
	}

	public void SetAttachEntityID(string entityID)
	{
	}

	public void LoadControllerByResUUID(string resUUID)
	{
	}

	public void Clean()
	{
	}

	private void onACResChanged(UGCResource res)
	{
	}

	public void LoadEmptyController()
	{
	}

	public void AttachAnimation(Animation ani)
	{
	}

	public void InitWithAnimatorOrAnimation(GameObject obj)
	{
	}

	public bool InitWithAnimation(Animation ani)
	{
		return false;
	}

	public bool InitWithAnimator(Animator ani)
	{
		return false;
	}

	public void InitWithResourceAndGameObject(GameObject aniObj, bool canUseEmptyRes = false)
	{
	}

	public void InitOrReattachAnimObject(GameObject aniObj, bool canUseEmptyRes = false)
	{
	}

	public bool IsAnimationStateOriginLoop(string stateName)
	{
		return false;
	}

	public void SyncAnimationState(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void SyncClipSpeed(string stateName, string currentClipName, float currentClipProgress, float currentClipSpeed, float currentStateSpeed)
	{
	}

	public void SyncClipLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void SyncStateLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void PlayClientCustomClip(AnimationClip clip, bool isLoop)
	{
	}

	public void PlayClientCustomRes(UGCResAnimationClip resObj, bool isLoop)
	{
	}

	public void PauseCurrentAnimation(bool isPause)
	{
	}

	public void SetBodyPartWeight(string partName, float weight)
	{
	}

	public void StopAnimationState(string stateName)
	{
	}
}
