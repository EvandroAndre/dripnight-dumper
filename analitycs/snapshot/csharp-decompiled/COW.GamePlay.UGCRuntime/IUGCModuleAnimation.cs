using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

internal interface IUGCModuleAnimation : IUGCModule
{
	UGCLogicEntity CreateAnimationController(string attachEntityID, string animationControllerResUUID);

	void PlayAnimationController(List<AJFJEGOPEPP> msgParams);

	void SetAnimationBodyPartWeight(List<AJFJEGOPEPP> msgParams);

	void StopAnimationState(List<AJFJEGOPEPP> msgParams);

	void SetAnimationClipSpeed(List<AJFJEGOPEPP> msgParams);

	void SetAnimationStateLoop(List<AJFJEGOPEPP> msgParams);
}
