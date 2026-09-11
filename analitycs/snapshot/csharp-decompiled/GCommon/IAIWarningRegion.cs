using UnityEngine;

namespace GCommon;

public interface IAIWarningRegion
{
	Transform transform { get; }

	void OnInit();

	void OnRecycle();

	GameObject GetGameObject();
}
