﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquisApp.DataServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BasicRequest", Namespace="http://schemas.datacontract.org/2004/07/DataService.DTOs.Requests")]
    [System.SerializableAttribute()]
    public partial class BasicRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerKeyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerKey {
            get {
                return this.ServerKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerKeyField, value) != true)) {
                    this.ServerKeyField = value;
                    this.RaisePropertyChanged("ServerKey");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BasicResponse", Namespace="http://schemas.datacontract.org/2004/07/DataService.DTOs.Responses")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(EquisApp.DataServiceReference.GetUserResponse))]
    public partial class BasicResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReturnCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnCode {
            get {
                return this.ReturnCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ReturnCodeField, value) != true)) {
                    this.ReturnCodeField = value;
                    this.RaisePropertyChanged("ReturnCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetUserResponse", Namespace="http://schemas.datacontract.org/2004/07/DataService.DTOs.Responses")]
    [System.SerializableAttribute()]
    public partial class GetUserResponse : EquisApp.DataServiceReference.BasicResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EquisApp.DataServiceReference.User[] UsersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EquisApp.DataServiceReference.User[] Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DataService.DTOs.Common")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReturnCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReturnStringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserLoginField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReturnCode {
            get {
                return this.ReturnCodeField;
            }
            set {
                if ((this.ReturnCodeField.Equals(value) != true)) {
                    this.ReturnCodeField = value;
                    this.RaisePropertyChanged("ReturnCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnString {
            get {
                return this.ReturnStringField;
            }
            set {
                if ((object.ReferenceEquals(this.ReturnStringField, value) != true)) {
                    this.ReturnStringField = value;
                    this.RaisePropertyChanged("ReturnString");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserLogin {
            get {
                return this.UserLoginField;
            }
            set {
                if ((object.ReferenceEquals(this.UserLoginField, value) != true)) {
                    this.UserLoginField = value;
                    this.RaisePropertyChanged("UserLogin");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataServiceReference.DataServiceApi")]
    public interface DataServiceApi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DataServiceApi/GetUsers", ReplyAction="http://tempuri.org/DataServiceApi/GetUsersResponse")]
        EquisApp.DataServiceReference.GetUserResponse GetUsers(EquisApp.DataServiceReference.BasicRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/DataServiceApi/GetUsers", ReplyAction="http://tempuri.org/DataServiceApi/GetUsersResponse")]
        System.IAsyncResult BeginGetUsers(EquisApp.DataServiceReference.BasicRequest request, System.AsyncCallback callback, object asyncState);
        
        EquisApp.DataServiceReference.GetUserResponse EndGetUsers(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DataServiceApi/CreateUpdateUser", ReplyAction="http://tempuri.org/DataServiceApi/CreateUpdateUserResponse")]
        void CreateUpdateUser(EquisApp.DataServiceReference.User request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/DataServiceApi/CreateUpdateUser", ReplyAction="http://tempuri.org/DataServiceApi/CreateUpdateUserResponse")]
        System.IAsyncResult BeginCreateUpdateUser(EquisApp.DataServiceReference.User request, System.AsyncCallback callback, object asyncState);
        
        void EndCreateUpdateUser(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataServiceApiChannel : EquisApp.DataServiceReference.DataServiceApi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public EquisApp.DataServiceReference.GetUserResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((EquisApp.DataServiceReference.GetUserResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceApiClient : System.ServiceModel.ClientBase<EquisApp.DataServiceReference.DataServiceApi>, EquisApp.DataServiceReference.DataServiceApi {
        
        private BeginOperationDelegate onBeginGetUsersDelegate;
        
        private EndOperationDelegate onEndGetUsersDelegate;
        
        private System.Threading.SendOrPostCallback onGetUsersCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateUpdateUserDelegate;
        
        private EndOperationDelegate onEndCreateUpdateUserDelegate;
        
        private System.Threading.SendOrPostCallback onCreateUpdateUserCompletedDelegate;
        
        public DataServiceApiClient() {
        }
        
        public DataServiceApiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceApiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceApiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceApiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetUsersCompletedEventArgs> GetUsersCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CreateUpdateUserCompleted;
        
        public EquisApp.DataServiceReference.GetUserResponse GetUsers(EquisApp.DataServiceReference.BasicRequest request) {
            return base.Channel.GetUsers(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetUsers(EquisApp.DataServiceReference.BasicRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetUsers(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public EquisApp.DataServiceReference.GetUserResponse EndGetUsers(System.IAsyncResult result) {
            return base.Channel.EndGetUsers(result);
        }
        
        private System.IAsyncResult OnBeginGetUsers(object[] inValues, System.AsyncCallback callback, object asyncState) {
            EquisApp.DataServiceReference.BasicRequest request = ((EquisApp.DataServiceReference.BasicRequest)(inValues[0]));
            return this.BeginGetUsers(request, callback, asyncState);
        }
        
        private object[] OnEndGetUsers(System.IAsyncResult result) {
            EquisApp.DataServiceReference.GetUserResponse retVal = this.EndGetUsers(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetUsersCompleted(object state) {
            if ((this.GetUsersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetUsersCompleted(this, new GetUsersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetUsersAsync(EquisApp.DataServiceReference.BasicRequest request) {
            this.GetUsersAsync(request, null);
        }
        
        public void GetUsersAsync(EquisApp.DataServiceReference.BasicRequest request, object userState) {
            if ((this.onBeginGetUsersDelegate == null)) {
                this.onBeginGetUsersDelegate = new BeginOperationDelegate(this.OnBeginGetUsers);
            }
            if ((this.onEndGetUsersDelegate == null)) {
                this.onEndGetUsersDelegate = new EndOperationDelegate(this.OnEndGetUsers);
            }
            if ((this.onGetUsersCompletedDelegate == null)) {
                this.onGetUsersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetUsersCompleted);
            }
            base.InvokeAsync(this.onBeginGetUsersDelegate, new object[] {
                        request}, this.onEndGetUsersDelegate, this.onGetUsersCompletedDelegate, userState);
        }
        
        public void CreateUpdateUser(EquisApp.DataServiceReference.User request) {
            base.Channel.CreateUpdateUser(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginCreateUpdateUser(EquisApp.DataServiceReference.User request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateUpdateUser(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndCreateUpdateUser(System.IAsyncResult result) {
            base.Channel.EndCreateUpdateUser(result);
        }
        
        private System.IAsyncResult OnBeginCreateUpdateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            EquisApp.DataServiceReference.User request = ((EquisApp.DataServiceReference.User)(inValues[0]));
            return this.BeginCreateUpdateUser(request, callback, asyncState);
        }
        
        private object[] OnEndCreateUpdateUser(System.IAsyncResult result) {
            this.EndCreateUpdateUser(result);
            return null;
        }
        
        private void OnCreateUpdateUserCompleted(object state) {
            if ((this.CreateUpdateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateUpdateUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateUpdateUserAsync(EquisApp.DataServiceReference.User request) {
            this.CreateUpdateUserAsync(request, null);
        }
        
        public void CreateUpdateUserAsync(EquisApp.DataServiceReference.User request, object userState) {
            if ((this.onBeginCreateUpdateUserDelegate == null)) {
                this.onBeginCreateUpdateUserDelegate = new BeginOperationDelegate(this.OnBeginCreateUpdateUser);
            }
            if ((this.onEndCreateUpdateUserDelegate == null)) {
                this.onEndCreateUpdateUserDelegate = new EndOperationDelegate(this.OnEndCreateUpdateUser);
            }
            if ((this.onCreateUpdateUserCompletedDelegate == null)) {
                this.onCreateUpdateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateUpdateUserCompleted);
            }
            base.InvokeAsync(this.onBeginCreateUpdateUserDelegate, new object[] {
                        request}, this.onEndCreateUpdateUserDelegate, this.onCreateUpdateUserCompletedDelegate, userState);
        }
    }
}
