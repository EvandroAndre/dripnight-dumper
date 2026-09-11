using UnityEngine;

namespace GCommon;

public interface IEasyList
{
	UIEasyListItemController OpenItemController(Transform parent);

	void CloseItemController(UIEasyListItemController itemController);
}
