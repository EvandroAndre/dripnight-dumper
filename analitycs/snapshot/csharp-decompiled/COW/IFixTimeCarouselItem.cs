using UnityEngine;

namespace COW;

public interface IFixTimeCarouselItem
{
	void Populate(object viewData);

	void SetLocalPosition(Vector3 pos);

	void OnCarouselEnter();
}
