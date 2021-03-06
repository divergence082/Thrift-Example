/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Example.Thrift.Types
{

  /// <summary>
  /// Диалог.
  /// 
  /// id: уникальный идентификатор диалога.
  /// 
  /// operatorId: идентификатор оператора.
  /// 
  /// visitorId: идентификатор посетителя.
  /// 
  /// state: состояние диалога.
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Dialog : TBase
  {

    public string DialogId { get; set; }

    public string OperatorId { get; set; }

    public string VisitorId { get; set; }

    /// <summary>
    /// 
    /// <seealso cref="DialogState"/>
    /// </summary>
    public DialogState State { get; set; }

    public Dialog() {
    }

    public Dialog(string dialogId, string operatorId, string visitorId, DialogState state) : this() {
      this.DialogId = dialogId;
      this.OperatorId = operatorId;
      this.VisitorId = visitorId;
      this.State = state;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_dialogId = false;
      bool isset_operatorId = false;
      bool isset_visitorId = false;
      bool isset_state = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              DialogId = iprot.ReadString();
              isset_dialogId = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              OperatorId = iprot.ReadString();
              isset_operatorId = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              VisitorId = iprot.ReadString();
              isset_visitorId = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              State = (DialogState)iprot.ReadI32();
              isset_state = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_dialogId)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_operatorId)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_visitorId)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_state)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Dialog");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "dialogId";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(DialogId);
      oprot.WriteFieldEnd();
      field.Name = "operatorId";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(OperatorId);
      oprot.WriteFieldEnd();
      field.Name = "visitorId";
      field.Type = TType.String;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(VisitorId);
      oprot.WriteFieldEnd();
      field.Name = "state";
      field.Type = TType.I32;
      field.ID = 4;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32((int)State);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Dialog(");
      __sb.Append(", DialogId: ");
      __sb.Append(DialogId);
      __sb.Append(", OperatorId: ");
      __sb.Append(OperatorId);
      __sb.Append(", VisitorId: ");
      __sb.Append(VisitorId);
      __sb.Append(", State: ");
      __sb.Append(State);
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
