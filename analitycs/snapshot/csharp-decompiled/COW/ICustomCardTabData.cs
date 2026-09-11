using System;

namespace COW;

public interface ICustomCardTabData
{
	int Index { get; }

	bool RedState { get; }

	Action<int> onSelected { get; set; }

	Action<bool> onRedState { get; set; }

	string GetTabName();

	void Init(int index);

	void Clear();
}
