
namespace csharp Example.Thrift.Services
namespace java example.thrift.services
namespace py example.thrift.services
namespace php Example.Thrift.Services


include "types.thrift"


/**
 * Сервис диалогов.
 */
service DialogService {

	/**
	 * Открытие диалога.
	 *
	 * @param subjectId - идентификатор субъекта диалога.
	 *
	 * @throws DialogError - ошибка сервиса диалогов.
	 *   Может возникать в случае отсутствия указанного субъекта.
	 */
	 types.Dialog open(1:types.SubjectId subjectId) throws (1:types.DialogError error);


	/**
	 * Переоткрытие диалога.
	 *
	 * @param dialogId - идентификатор диалога.
	 *
	 * @throws DialogError - ошибка сервиса диалогов.
	 *   Может возникать в случае отсутствия указанного диалога
	 *   или если субъект не являлся участником диалога.
	 */
	 types.Dialog reopen(1:types.DialogId dialogId) throws (1:types.DialogError error);


	/**
	 * Закрытие диалога.
	 *
	 * @throws DialogError - ошибка сервиса диалогов.
	 *   Может возникать в случае отсутствия диалога.
	 */
	 types.DialogState close() throws (1:types.DialogError error);


	/**
	 * Отправка текстового сообщения.
	 *
	 * @param text - текст сообщения.
	 *
	 * @throws DialogError - ошибка сервиса диалогов.
	 *   Может возникать в случае отсутствия текущего диалога.
	 */
	 types.Message sendTextMessage(1:string text) throws (1:types.DialogError error);

}