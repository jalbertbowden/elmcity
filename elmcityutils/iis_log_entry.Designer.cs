﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 8/13/2010 1:54:50 PM
namespace ElmcityUtils
{
    
    /// <summary>
    /// There are no comments for iis_log_entry_entities in the schema.
    /// </summary>
    public partial class iis_log_entry_entities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new iis_log_entry_entities object using the connection string found in the 'iis_log_entry_entities' section of the application configuration file.
        /// </summary>
        public iis_log_entry_entities() : 
                base("name=iis_log_entry_entities", "iis_log_entry_entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new iis_log_entry_entities object.
        /// </summary>
        public iis_log_entry_entities(string connectionString) : 
                base(connectionString, "iis_log_entry_entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new iis_log_entry_entities object.
        /// </summary>
        public iis_log_entry_entities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "iis_log_entry_entities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for iis_log_entry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<iis_log_entry> iis_log_entry
        {
            get
            {
                if ((this._iis_log_entry == null))
                {
                    this._iis_log_entry = base.CreateQuery<iis_log_entry>("[iis_log_entry]");
                }
                return this._iis_log_entry;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<iis_log_entry> _iis_log_entry;
        /// <summary>
        /// There are no comments for iis_log_entry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToiis_log_entry(iis_log_entry iis_log_entry)
        {
            base.AddObject("iis_log_entry", iis_log_entry);
        }
    }
    /// <summary>
    /// There are no comments for iis_log_entry.iis_log_entry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="iis_log_entry", Name="iis_log_entry")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class iis_log_entry : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new iis_log_entry object.
        /// </summary>
        /// <param name="id">Initial value of ID.</param>
        /// <param name="datetime">Initial value of datetime.</param>
        /// <param name="server">Initial value of server.</param>
        /// <param name="verb">Initial value of verb.</param>
        /// <param name="url">Initial value of url.</param>
        /// <param name="ip">Initial value of ip.</param>
        /// <param name="status">Initial value of status.</param>
        /// <param name="sent_bytes">Initial value of sent_bytes.</param>
        /// <param name="recv_bytes">Initial value of recv_bytes.</param>
        /// <param name="time_taken">Initial value of time_taken.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static iis_log_entry Createiis_log_entry(int id, global::System.DateTime datetime, string server, string verb, string url, string ip, int status, int sent_bytes, int recv_bytes, int time_taken)
        {
            iis_log_entry iis_log_entry = new iis_log_entry();
            iis_log_entry.ID = id;
            iis_log_entry.datetime = datetime;
            iis_log_entry.server = server;
            iis_log_entry.verb = verb;
            iis_log_entry.url = url;
            iis_log_entry.ip = ip;
            iis_log_entry.status = status;
            iis_log_entry.sent_bytes = sent_bytes;
            iis_log_entry.recv_bytes = recv_bytes;
            iis_log_entry.time_taken = time_taken;
            return iis_log_entry;
        }
        /// <summary>
        /// There are no comments for property ID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this.ReportPropertyChanging("ID");
                this._ID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ID");
                this.OnIDChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _ID;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIDChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for property datetime in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime datetime
        {
            get
            {
                return this._datetime;
            }
            set
            {
                this.OndatetimeChanging(value);
                this.ReportPropertyChanging("datetime");
                this._datetime = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("datetime");
                this.OndatetimeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _datetime;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OndatetimeChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OndatetimeChanged();
        /// <summary>
        /// There are no comments for property server in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string server
        {
            get
            {
                return this._server;
            }
            set
            {
                this.OnserverChanging(value);
                this.ReportPropertyChanging("server");
                this._server = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("server");
                this.OnserverChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _server;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnserverChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnserverChanged();
        /// <summary>
        /// There are no comments for property verb in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string verb
        {
            get
            {
                return this._verb;
            }
            set
            {
                this.OnverbChanging(value);
                this.ReportPropertyChanging("verb");
                this._verb = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("verb");
                this.OnverbChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _verb;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnverbChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnverbChanged();
        /// <summary>
        /// There are no comments for property url in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string url
        {
            get
            {
                return this._url;
            }
            set
            {
                this.OnurlChanging(value);
                this.ReportPropertyChanging("url");
                this._url = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("url");
                this.OnurlChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _url;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnurlChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnurlChanged();
        /// <summary>
        /// There are no comments for property ip in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string ip
        {
            get
            {
                return this._ip;
            }
            set
            {
                this.OnipChanging(value);
                this.ReportPropertyChanging("ip");
                this._ip = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ip");
                this.OnipChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _ip;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnipChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnipChanged();
        /// <summary>
        /// There are no comments for property http_version in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string http_version
        {
            get
            {
                return this._http_version;
            }
            set
            {
                this.Onhttp_versionChanging(value);
                this.ReportPropertyChanging("http_version");
                this._http_version = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("http_version");
                this.Onhttp_versionChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _http_version;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onhttp_versionChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onhttp_versionChanged();
        /// <summary>
        /// There are no comments for property user_agent in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string user_agent
        {
            get
            {
                return this._user_agent;
            }
            set
            {
                this.Onuser_agentChanging(value);
                this.ReportPropertyChanging("user_agent");
                this._user_agent = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("user_agent");
                this.Onuser_agentChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _user_agent;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onuser_agentChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onuser_agentChanged();
        /// <summary>
        /// There are no comments for property referrer in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string referrer
        {
            get
            {
                return this._referrer;
            }
            set
            {
                this.OnreferrerChanging(value);
                this.ReportPropertyChanging("referrer");
                this._referrer = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("referrer");
                this.OnreferrerChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _referrer;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnreferrerChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnreferrerChanged();
        /// <summary>
        /// There are no comments for property status in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int status
        {
            get
            {
                return this._status;
            }
            set
            {
                this.OnstatusChanging(value);
                this.ReportPropertyChanging("status");
                this._status = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("status");
                this.OnstatusChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _status;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnstatusChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnstatusChanged();
        /// <summary>
        /// There are no comments for property w32_status in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Nullable<int> w32_status
        {
            get
            {
                return this._w32_status;
            }
            set
            {
                this.Onw32_statusChanging(value);
                this.ReportPropertyChanging("w32_status");
                this._w32_status = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("w32_status");
                this.Onw32_statusChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Nullable<int> _w32_status;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onw32_statusChanging(global::System.Nullable<int> value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onw32_statusChanged();
        /// <summary>
        /// There are no comments for property sent_bytes in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int sent_bytes
        {
            get
            {
                return this._sent_bytes;
            }
            set
            {
                this.Onsent_bytesChanging(value);
                this.ReportPropertyChanging("sent_bytes");
                this._sent_bytes = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("sent_bytes");
                this.Onsent_bytesChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _sent_bytes;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onsent_bytesChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onsent_bytesChanged();
        /// <summary>
        /// There are no comments for property recv_bytes in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int recv_bytes
        {
            get
            {
                return this._recv_bytes;
            }
            set
            {
                this.Onrecv_bytesChanging(value);
                this.ReportPropertyChanging("recv_bytes");
                this._recv_bytes = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("recv_bytes");
                this.Onrecv_bytesChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _recv_bytes;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onrecv_bytesChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Onrecv_bytesChanged();
        /// <summary>
        /// There are no comments for property time_taken in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int time_taken
        {
            get
            {
                return this._time_taken;
            }
            set
            {
                this.Ontime_takenChanging(value);
                this.ReportPropertyChanging("time_taken");
                this._time_taken = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("time_taken");
                this.Ontime_takenChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _time_taken;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontime_takenChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void Ontime_takenChanged();
    }
}