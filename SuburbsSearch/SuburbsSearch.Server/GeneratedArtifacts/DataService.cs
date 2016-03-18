﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
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
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Inserting(global::LightSwitchApplication.Suburb entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Inserted(global::LightSwitchApplication.Suburb entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Updating(global::LightSwitchApplication.Suburb entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Updated(global::LightSwitchApplication.Suburb entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Deleting(global::LightSwitchApplication.Suburb entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Deleted(global::LightSwitchApplication.Suburb entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Validate(global::LightSwitchApplication.Suburb entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Suburbs_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Suburb, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Inserting(global::LightSwitchApplication.Matter entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Inserted(global::LightSwitchApplication.Matter entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Updating(global::LightSwitchApplication.Matter entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Updated(global::LightSwitchApplication.Matter entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Deleting(global::LightSwitchApplication.Matter entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Deleted(global::LightSwitchApplication.Matter entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Validate(global::LightSwitchApplication.Matter entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Matters_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Matter, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Inserting(global::LightSwitchApplication.Contact entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Inserted(global::LightSwitchApplication.Contact entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Updating(global::LightSwitchApplication.Contact entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Updated(global::LightSwitchApplication.Contact entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Deleting(global::LightSwitchApplication.Contact entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Deleted(global::LightSwitchApplication.Contact entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Validate(global::LightSwitchApplication.Contact entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contacts_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Contact, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SuburbByLocality_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void SuburbByLocality_Executing(string Locality);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SuburbByLocality_PreprocessQuery(string Locality, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Suburb> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void SuburbByLocality_Executed(string Locality, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Suburb> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void SuburbByLocality_ExecuteFailed(string Locality, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ContactByName_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void ContactByName_Executing(string Name);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ContactByName_PreprocessQuery(string Name, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Contact> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void ContactByName_Executed(string Name, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Contact> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void ContactByName_ExecuteFailed(string Name, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executing(global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executed(global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_ExecuteFailed(global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ApplicationData_InitializingConnection(global::Microsoft.LightSwitch.DatabaseConnectionState state);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Suburb>
                __SuburbsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Suburb>(
                    "Suburbs",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Suburbs_Filter);
            private static bool __Suburbs_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Suburbs_CanInsert(ref result);
                return result;
            }
            private static bool __Suburbs_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Suburbs_CanUpdate(ref result);
                return result;
            }
            private static bool __Suburbs_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Suburbs_CanDelete(ref result);
                return result;
            }
            private static bool __Suburbs_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Suburbs_CanRead(ref result);
                return result;
            }
            private static void __Suburbs_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e)
            {
                d.Suburbs_Inserting(e);
            }
            private static void __Suburbs_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e)
            {
                d.Suburbs_Inserted(e);
            }
            private static void __Suburbs_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e)
            {
                d.Suburbs_Updating(e);
            }
            private static void __Suburbs_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e)
            {
                d.Suburbs_Updated(e);
            }
            private static void __Suburbs_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e)
            {
                d.Suburbs_Deleting(e);
            }
            private static void __Suburbs_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e)
            {
                d.Suburbs_Deleted(e);
            }
            private static void __Suburbs_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Suburb e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Suburbs_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Suburb, bool>> __Suburbs_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Suburb, bool>> filter = null;
                d.Suburbs_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Matter>
                __MattersEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Matter>(
                    "Matters",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Matters_Filter);
            private static bool __Matters_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Matters_CanInsert(ref result);
                return result;
            }
            private static bool __Matters_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Matters_CanUpdate(ref result);
                return result;
            }
            private static bool __Matters_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Matters_CanDelete(ref result);
                return result;
            }
            private static bool __Matters_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Matters_CanRead(ref result);
                return result;
            }
            private static void __Matters_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e)
            {
                d.Matters_Inserting(e);
            }
            private static void __Matters_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e)
            {
                d.Matters_Inserted(e);
            }
            private static void __Matters_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e)
            {
                d.Matters_Updating(e);
            }
            private static void __Matters_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e)
            {
                d.Matters_Updated(e);
            }
            private static void __Matters_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e)
            {
                d.Matters_Deleting(e);
            }
            private static void __Matters_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e)
            {
                d.Matters_Deleted(e);
            }
            private static void __Matters_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Matter e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Matters_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Matter, bool>> __Matters_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Matter, bool>> filter = null;
                d.Matters_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Contact>
                __ContactsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Contact>(
                    "Contacts",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Contacts_Filter);
            private static bool __Contacts_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Contacts_CanInsert(ref result);
                return result;
            }
            private static bool __Contacts_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Contacts_CanUpdate(ref result);
                return result;
            }
            private static bool __Contacts_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Contacts_CanDelete(ref result);
                return result;
            }
            private static bool __Contacts_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Contacts_CanRead(ref result);
                return result;
            }
            private static void __Contacts_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e)
            {
                d.Contacts_Inserting(e);
            }
            private static void __Contacts_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e)
            {
                d.Contacts_Inserted(e);
            }
            private static void __Contacts_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e)
            {
                d.Contacts_Updating(e);
            }
            private static void __Contacts_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e)
            {
                d.Contacts_Updated(e);
            }
            private static void __Contacts_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e)
            {
                d.Contacts_Deleting(e);
            }
            private static void __Contacts_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e)
            {
                d.Contacts_Deleted(e);
            }
            private static void __Contacts_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Contact e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Contacts_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Contact, bool>> __Contacts_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Contact, bool>> filter = null;
                d.Contacts_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Suburb>
                __SuburbByLocalityEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Suburb>(
                    "SuburbByLocality",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SuburbByLocality_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SuburbByLocality_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SuburbByLocality_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SuburbByLocality_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SuburbByLocality_PreprocessQuery);
            private static bool __SuburbByLocality_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SuburbByLocality_CanExecute(ref r);
                return r;
            }
            private static void __SuburbByLocality_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SuburbByLocality_Executing((string)args[0]);
            }
            private static void __SuburbByLocality_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SuburbByLocality_Executed((string)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Suburb>)args[1]);
            }
            private static void __SuburbByLocality_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SuburbByLocality_ExecuteFailed((string)args[0], ex);
            }
            private static global::System.Linq.IQueryable __SuburbByLocality_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Suburb> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Suburb>)args[1];
                d.SuburbByLocality_PreprocessQuery((string)args[0], ref query);
                return query;
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Contact>
                __ContactByNameEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Contact>(
                    "ContactByName",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ContactByName_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ContactByName_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ContactByName_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ContactByName_Failed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ContactByName_PreprocessQuery);
            private static bool __ContactByName_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.ContactByName_CanExecute(ref r);
                return r;
            }
            private static void __ContactByName_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.ContactByName_Executing((string)args[0]);
            }
            private static void __ContactByName_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.ContactByName_Executed((string)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Contact>)args[1]);
            }
            private static void __ContactByName_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.ContactByName_ExecuteFailed((string)args[0], ex);
            }
            private static global::System.Linq.IQueryable __ContactByName_PreprocessQuery(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Contact> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Contact>)args[1];
                d.ContactByName_PreprocessQuery((string)args[0], ref query);
                return query;
            }
    
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>
                ___QueryEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Failed);
            private static void __Query_Executing(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor)
            {
                d.Query_Executing(queryDescriptor);
            }
            private static void __Query_Executed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor)
            {
                d.Query_Executed(queryDescriptor);
            }
            private static void __Query_Failed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor)
            {
                d.Query_ExecuteFailed(queryDescriptor);
            }
    
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.DatabaseAuthEntry<global::LightSwitchApplication.ApplicationDataService>
                ___DatabaseAuthEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.DatabaseAuthEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ApplicationData_InitializingConnection);
            private static void __ApplicationData_InitializingConnection(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.DatabaseConnectionState state)
            {
                d.ApplicationData_InitializingConnection(state);
            }
        }
    
        #endregion
    }
    
    #endregion
}
