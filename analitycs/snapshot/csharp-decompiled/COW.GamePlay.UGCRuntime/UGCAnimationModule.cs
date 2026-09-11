using System.Collections.Generic;
using COW.Gameplay.UGC;
using message;

namespace COW.GamePlay.UGCRuntime;

internal class UGCAnimationModule : IUGCModuleAnimation, IUGCModule
{
	private Dictionary<string, UGCAnimationControllerEntity> ControllerMap;

	private Dictionary<string, UGCAnimationStateEntity> StateMap;

	private Dictionary<string, UGCAnimationClipEntity> ClipMap;

	private UGCRuntime ugcRuntime;

	private UGCEntityDataStore dataStore;

	private uint lastTickGameTime;

	public UGCEntityDataStore DataStore => null;

	public UGCAnimationStateEntity LookupState(string entityID)
	{
		return null;
	}

	public UGCAnimationClipEntity LookupClip(string entityID)
	{
		return null;
	}

	public UGCAnimationControllerEntity LookupController(string entityID)
	{
		return null;
	}

	public void PlayAnimationController(List<AJFJEGOPEPP> msgParams)
	{
	}

	public void SetAnimationBodyPartWeight(List<AJFJEGOPEPP> msgParams)
	{
	}

	public void StopAnimationState(List<AJFJEGOPEPP> msgParams)
	{
	}

	public void SetAnimationClipSpeed(List<AJFJEGOPEPP> msgParams)
	{
	}

	public void SetAnimationStateLoop(List<AJFJEGOPEPP> msgParams)
	{
	}

	public UGCAnimationControllerEntity ValidateAnimationController(string entityID)
	{
		return null;
	}

	public void AddOrSetAnimationController(string entityID, UGCAnimationControllerEntity acEntity)
	{
	}

	private void OnAddAnimationController(string entityID)
	{
	}

	private void OnRemoveAnimationController(string entityID)
	{
	}

	private void OnAddAnimationState(string entityID)
	{
	}

	private void OnRemoveAnimationState(string entityID)
	{
	}

	private void OnAddAnimationClip(string entityID)
	{
	}

	private void OnRemoveAnimationClip(string entityID)
	{
	}

	public IUGCModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	private void OnAddCustomLevelObject(string entityID)
	{
	}

	public void Destroy()
	{
	}

	public UGCLogicEntity CreateAnimationController(string attachEntityID, string animationControllerResUUID)
	{
		return null;
	}
}
