using UnityEngine;

namespace COW;

public interface IOnTriggerEnterExit
{
	void OnTriggerEnter(Collider other);

	void OnTriggerExit(Collider other);
}
