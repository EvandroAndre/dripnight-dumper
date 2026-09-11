using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCModule
{
	void Init(object[] args);

	void LoadParameters(Dictionary<object, object> parameters);

	void Destroy();
}
