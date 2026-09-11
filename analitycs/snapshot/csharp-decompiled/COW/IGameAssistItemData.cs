using System.Collections.Generic;

namespace COW;

public interface IGameAssistItemData
{
	ulong Assist_Id { get; set; }

	ELobbyAssistDataType SubType { get; set; }

	bool NeedHideLine { get; set; }

	bool HasRead { get; set; }

	bool CheckCanAddToList();

	bool CheckAssistStateIsFit(bool checkNewMessage);

	void AddDataToViewList(uint index, List<IGameAssistItemData> list);
}
