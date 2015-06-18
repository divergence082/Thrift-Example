
namespace csharp Example.Thrift.Types
namespace java example.thrift.types
namespace py example.thrift.types
namespace php Example.Thrift.Types


/**
 * Идентификатор субъекта диалога.
 **/
typedef string SubjectId


/**
 * Статус участника диалога.
 */
enum SubjectStatus {
  OFFLINE = 0,
  ONLINE = 1
}


/**
 * Субъект диалога.
 *
 * id: уникальный идентификатор субъекта.
 *
 * status: актуальный статус субъекта.
 *
 * name: имя субъекта.
 *
 * email: адрес электронной почты субъекта.
 *
 * phone: номер контактного телефона субъекта.
 */
struct Subject {
	1: required SubjectId subjectId;
	2: required SubjectStatus status;
	3: required string name;
	4: required string email;
	5: required string phone;
}


/**
 * Состояние диалога.
 */
enum DialogState {
  ENQUEUED = 0,
  OPENED = 1,
  CLOSED = 2,
  REOPENED = 2
}


/**
 * Идентификатор диалога.
 **/
typedef string DialogId


/**
 * Диалог.
 *
 * id: уникальный идентификатор диалога.
 *
 * operatorId: идентификатор оператора.
 *
 * visitorId: идентификатор посетителя.
 *
 * state: состояние диалога.
 */
struct Dialog {
	1: required DialogId dialogId;
	2: required SubjectId operatorId;
	3: required SubjectId visitorId;
	4: required DialogState state;
}


/**
 * Идентификатор сообщения.
 **/
typedef string MessageId


/**
 * Сообщение.
 *
 * id: уникальный идентификатор сообщения.
 *
 * dialogId: идентификатор диалога, в контексте которого создано сообщение.
 *
 * senderId: идентификатор субъекта, создавшего сообщение.
 *
 * text: текст сообщения.
 */
struct Message {
	1: required MessageId messageId;
	2: required DialogId dialogId;
	3: required SubjectId senderId;
	4: required string text;
}


/**
 * Ошибка сервиса диалогов.
 *
 * message: сообщение об ошибке.
 *
 * code: код ошибки.
 */
exception DialogError {
  1: required string message;
  2: optional i16 code;
}
