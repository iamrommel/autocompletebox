﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Contact
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Contact :
        global::LightSwitchApplication.Contact.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Contact.DetailsClass.IImplementation.Matters
        {
            get
            {
                return this.Matters;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Matter> __Matters
        {
            get
            {
                if (this.___Matters == null)
                {
                    this.___Matters = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Matter>(
                        this,
                        "Matters",
                        () => this._Matters,
                        e => global::System.Object.Equals(e.Matter_Contact, this.Id));
                }
                return this.___Matters;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Matter> ___Matters;
        
    }
    #endregion
    
    #region Matter
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Matter :
        global::LightSwitchApplication.Matter.DetailsClass.IImplementation
    {
        partial void OnMatter_SuburbChanged()
        {
            this.___OnPropertyChanged("Matter_Suburb");
            this.___OnPropertyChanged("Suburb");
        }
        
        partial void OnMatter_ContactChanged()
        {
            this.___OnPropertyChanged("Matter_Contact");
            this.___OnPropertyChanged("Contact");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Matter.DetailsClass.IImplementation.Suburb
        {
            get
            {
                return this.Suburb;
            }
            set
            {
                this.Suburb = (global::LightSwitchApplication.Implementation.Suburb)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Suburb> __Suburb
        {
            get
            {
                if (this.___Suburb == null)
                {
                    this.___Suburb = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Suburb>(
                        this,
                        "Suburb",
                        new string[] { "Matter_Suburb" },
                        e => global::System.Object.Equals(e.Id, this.Matter_Suburb),
                        () => this._Suburb,
                        e => this._Suburb = e);
                }
                return this.___Suburb;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Suburb> ___Suburb;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Matter.DetailsClass.IImplementation.Contact
        {
            get
            {
                return this.Contact;
            }
            set
            {
                this.Contact = (global::LightSwitchApplication.Implementation.Contact)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Contact> __Contact
        {
            get
            {
                if (this.___Contact == null)
                {
                    this.___Contact = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Contact>(
                        this,
                        "Contact",
                        new string[] { "Matter_Contact" },
                        e => global::System.Object.Equals(e.Id, this.Matter_Contact),
                        () => this._Contact,
                        e => this._Contact = e);
                }
                return this.___Contact;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Contact> ___Contact;
        
    }
    #endregion
    
    #region Suburb
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Suburb :
        global::LightSwitchApplication.Suburb.DetailsClass.IImplementation
    {
        partial void OnSuburb_StateChanged()
        {
            this.___OnPropertyChanged("Suburb_State");
            this.___OnPropertyChanged("State");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnLocalityChanged()
        {
            this.___OnPropertyChanged("Locality");
        }
        
        partial void OnPostCodeChanged()
        {
            this.___OnPropertyChanged("PostCode");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Suburb.DetailsClass.IImplementation.Matters
        {
            get
            {
                return this.Matters;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Matter> __Matters
        {
            get
            {
                if (this.___Matters == null)
                {
                    this.___Matters = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Matter>(
                        this,
                        "Matters",
                        () => this._Matters,
                        e => global::System.Object.Equals(e.Matter_Suburb, this.Id));
                }
                return this.___Matters;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Matter> ___Matters;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Suburb.DetailsClass.IImplementation.State
        {
            get
            {
                return this.State;
            }
            set
            {
                this.State = (global::LightSwitchApplication.Implementation.State)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.State> __State
        {
            get
            {
                if (this.___State == null)
                {
                    this.___State = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.State>(
                        this,
                        "State",
                        new string[] { "Suburb_State" },
                        e => global::System.Object.Equals(e.Id, this.Suburb_State),
                        () => this._State,
                        e => this._State = e);
                }
                return this.___State;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.State> ___State;
        
    }
    #endregion
    
    #region State
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class State :
        global::LightSwitchApplication.State.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.State.DetailsClass.IImplementation.Suburbs
        {
            get
            {
                return this.Suburbs;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Suburb> __Suburbs
        {
            get
            {
                if (this.___Suburbs == null)
                {
                    this.___Suburbs = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Suburb>(
                        this,
                        "Suburbs",
                        () => this._Suburbs,
                        e => global::System.Object.Equals(e.Suburb_State, this.Id));
                }
                return this.___Suburbs;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Suburb> ___Suburbs;
        
    }
    #endregion
    
    #region ApplicationData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationData
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Contact))
            {
                return new global::LightSwitchApplication.Implementation.Contact();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Matter))
            {
                return new global::LightSwitchApplication.Implementation.Matter();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Suburb))
            {
                return new global::LightSwitchApplication.Implementation.Suburb();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.State))
            {
                return new global::LightSwitchApplication.Implementation.State();
            }
            return null;
        }
        
        protected override void InitializeDataServiceContext()
        {
            this.Format.LoadServiceModel = global::LightSwitchApplication.Implementation.ApplicationData.GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationData(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Contact) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Contact);
            }
            if (typeof(global::LightSwitchApplication.Matter) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Matter);
            }
            if (typeof(global::LightSwitchApplication.Suburb) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Suburb);
            }
            if (typeof(global::LightSwitchApplication.State) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.State);
            }
            return null;
        }
    }
}
