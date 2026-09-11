using UnityEngine;

namespace GCommon;

public interface IReusableObjectOwner
{
	void OnReusableObjectRecycled(ResourceID rID, GameObject obj);
}
