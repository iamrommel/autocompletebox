﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    public sealed partial class Suburb : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Suburb entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Suburb()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Suburb(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Suburb> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Suburb.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburb_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburb_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Suburb.DetailsClass.GetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Suburb.DetailsClass.SetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Locality
        {
            get
            {
                return global::LightSwitchApplication.Suburb.DetailsClass.GetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Locality);
            }
            set
            {
                global::LightSwitchApplication.Suburb.DetailsClass.SetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Locality, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Locality_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Locality_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Locality_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string PostCode
        {
            get
            {
                return global::LightSwitchApplication.Suburb.DetailsClass.GetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.PostCode);
            }
            set
            {
                global::LightSwitchApplication.Suburb.DetailsClass.SetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.PostCode, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PostCode_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PostCode_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PostCode_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.Suburb.DetailsClass.GetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.Suburb.DetailsClass.SetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Matter> Matters
        {
            get
            {
                return global::LightSwitchApplication.Suburb.DetailsClass.GetValue(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Matters);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Matter> MattersQuery
        {
            get
            {
                return global::LightSwitchApplication.Suburb.DetailsClass.GetQuery(this, global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Matters);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Suburb,
                global::LightSwitchApplication.Suburb.DetailsClass,
                global::LightSwitchApplication.Suburb.DetailsClass.IImplementation,
                global::LightSwitchApplication.Suburb.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass>.Entry
                __SuburbEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass>.Entry(
                    global::LightSwitchApplication.Suburb.DetailsClass.__Suburb_CreateNew,
                    global::LightSwitchApplication.Suburb.DetailsClass.__Suburb_Created,
                    global::LightSwitchApplication.Suburb.DetailsClass.__Suburb_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Suburb __Suburb_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Suburb> es)
            {
                return new global::LightSwitchApplication.Suburb(es);
            }
            private static void __Suburb_Created(global::LightSwitchApplication.Suburb e)
            {
                e.Suburb_Created();
            }
            private static bool __Suburb_AllowSaveWithErrors(global::LightSwitchApplication.Suburb e)
            {
                bool result = false;
                e.Suburb_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Suburb.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string> Locality
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Locality) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string> PostCode
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.PostCode) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, global::LightSwitchApplication.Matter> Matters
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Matters) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, global::LightSwitchApplication.Matter>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string Locality { get; set; }
                new string PostCode { get; set; }
                new byte[] RowVersion { get; set; }
                new global::System.Collections.IEnumerable Matters { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Suburb.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, int>.Data> c, global::LightSwitchApplication.Suburb.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Suburb e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Suburb e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Suburb e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Entry
                    Locality = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Entry(
                        "Locality",
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Locality_Stub,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Locality_ComputeIsReadOnly,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Locality_Validate,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Locality_GetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Locality_SetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Locality_OnValueChanged);
                private static void _Locality_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Suburb.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Data> c, global::LightSwitchApplication.Suburb.DetailsClass d, object sf)
                {
                    c(d, ref d._Locality, sf);
                }
                private static bool _Locality_ComputeIsReadOnly(global::LightSwitchApplication.Suburb e)
                {
                    bool result = false;
                    e.Locality_IsReadOnly(ref result);
                    return result;
                }
                private static void _Locality_Validate(global::LightSwitchApplication.Suburb e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Locality_Validate(r);
                }
                private static string _Locality_GetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d)
                {
                    return d.ImplementationEntity.Locality;
                }
                private static void _Locality_SetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Locality = v;
                }
                private static void _Locality_OnValueChanged(global::LightSwitchApplication.Suburb e)
                {
                    e.Locality_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Entry
                    PostCode = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Entry(
                        "PostCode",
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._PostCode_Stub,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._PostCode_ComputeIsReadOnly,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._PostCode_Validate,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._PostCode_GetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._PostCode_SetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._PostCode_OnValueChanged);
                private static void _PostCode_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Suburb.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Data> c, global::LightSwitchApplication.Suburb.DetailsClass d, object sf)
                {
                    c(d, ref d._PostCode, sf);
                }
                private static bool _PostCode_ComputeIsReadOnly(global::LightSwitchApplication.Suburb e)
                {
                    bool result = false;
                    e.PostCode_IsReadOnly(ref result);
                    return result;
                }
                private static void _PostCode_Validate(global::LightSwitchApplication.Suburb e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.PostCode_Validate(r);
                }
                private static string _PostCode_GetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d)
                {
                    return d.ImplementationEntity.PostCode;
                }
                private static void _PostCode_SetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d, string v)
                {
                    d.ImplementationEntity.PostCode = v;
                }
                private static void _PostCode_OnValueChanged(global::LightSwitchApplication.Suburb e)
                {
                    e.PostCode_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Suburb.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.Suburb.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.Suburb e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.Suburb e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.Suburb.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.Suburb e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, global::LightSwitchApplication.Matter>.Entry
                    Matters = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, global::LightSwitchApplication.Matter>.Entry(
                        "Matters",
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Matters_Stub,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Matters_GetReferencedEntities,
                        global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties._Matters_GetEntityCollection);
                private static void _Matters_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Suburb.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, global::LightSwitchApplication.Matter>.Data> c, global::LightSwitchApplication.Suburb.DetailsClass d, object sf)
                {
                    c(d, ref d._Matters, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Matter> _Matters_GetReferencedEntities(global::LightSwitchApplication.Suburb.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Matter, global::LightSwitchApplication.Matter.DetailsClass>(global::LightSwitchApplication.Suburb.DetailsClass.PropertySetProperties.Matters, ref d._Matters);
                }
                private static global::System.Collections.IEnumerable _Matters_GetEntityCollection(global::LightSwitchApplication.Suburb.DetailsClass d)
                {
                    return d.ImplementationEntity.Matters;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Data _Locality;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, string>.Data _PostCode;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Suburb, global::LightSwitchApplication.Suburb.DetailsClass, global::LightSwitchApplication.Matter>.Data _Matters;
            
        }
    
        #endregion
    }
    
    #endregion
}
