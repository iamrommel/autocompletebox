using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;
using System.Windows.Controls;
using Microsoft.LightSwitch.Presentation.Implementation.Controls;

namespace LightSwitchApplication
{
    public partial class MatterScreen
    {
        partial void MatterScreen_Created()
        {
            SuburbControl.ControlAvailable -= SuburbControl_ControlAvailable;
            SuburbControl.ControlAvailable += SuburbControl_ControlAvailable;

            ContactControl.ControlAvailable -= ContactControl_ControlAvailable;
            ContactControl.ControlAvailable += ContactControl_ControlAvailable;
        }


        #region Suburb AutocompleteBox

        private void SuburbControl_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {

            var automComplete = e.Control as AutoCompleteBox;

            automComplete.MinimumPrefixLength = 3;
            automComplete.IsTextCompletionEnabled = false;
            automComplete.MinimumPopulateDelay = 600;
            automComplete.FilterMode = AutoCompleteFilterMode.None;
            automComplete.Populating -= OnSuburbAutoCompleteOnPopulating;
            automComplete.Populating += OnSuburbAutoCompleteOnPopulating;


        }


        private void OnSuburbAutoCompleteOnPopulating(object sender, PopulatingEventArgs e)
        {
            LocalityFilter = e.Parameter;
        }

        private IContentItemProxy _suburbControl;
        private IContentItemProxy SuburbControl
        {
            get
            {
                if (_suburbControl == null)
                {
                    _suburbControl = this.FindControl("SuburbControl");
                }

                return _suburbControl;
            }
        }
        #endregion

        #region Contact AutocompleBox
        private IContentItemProxy _contactControl;
        private IContentItemProxy ContactControl
        {
            get
            {
                if (_contactControl == null)
                {
                    _contactControl = this.FindControl("ContactControl");
                }

                return _contactControl;
            }
        }

        private void ContactControl_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            var automComplete = e.Control as AutoCompleteBox;
            automComplete.MinimumPrefixLength = 3;
            automComplete.IsTextCompletionEnabled = false;
            automComplete.MinimumPopulateDelay = 600;
            automComplete.FilterMode = AutoCompleteFilterMode.None;

            automComplete.Populating -= OnContactAutoCompleteOnPopulating;
            automComplete.Populating += OnContactAutoCompleteOnPopulating;

            //automComplete.DropDownClosing -= ContactAutoComplete_DropDownClosing;
            //automComplete.DropDownClosing += ContactAutoComplete_DropDownClosing;

            automComplete.DropDownClosed -= AutomComplete_DropDownClosed;
            automComplete.DropDownClosed += AutomComplete_DropDownClosed;


        }

        private bool _beenHere;
        private void AutomComplete_DropDownClosed(object sender, System.Windows.RoutedPropertyChangedEventArgs<bool> e)
        {
            var automComplete = sender as AutoCompleteBox;
            if (automComplete == null) return;
            var itemWrapper = automComplete.SelectedItem as AutoCompleteBoxVisual.TemplateContentItemWrapper;
            if (itemWrapper == null) return;

            var contact = itemWrapper.Value as Contact;
            if (contact == null) return;

            //do the saving here
            //TODO: Should compare for Id and not the name, but for the sake of simplicity that should do it
            if (contact.Name != "***Add New" /* && _beenHere */)
            {

                return;
            };

            var name = automComplete.SearchText;

            this.Details.Dispatcher.BeginInvoke(() =>
            {
                if (Matters.SelectedItem.Contact.Details.EntityState != EntityState.Added)
                {
                    _beenHere = true;
                    if (_newContact != null)
                        _newContact.Details.DiscardChanges();

                    _newContact = this.DataWorkspace.ApplicationData.Contacts.AddNew();
                    //create a new contact and assign it
                    Matters.SelectedItem.Contact =_newContact ;
                    Matters.SelectedItem.Contact.Name = name;

                }
            });

        }

        private Contact _newContact;
        private void ContactAutoComplete_DropDownClosing(object sender, RoutedPropertyChangingEventArgs<bool> e)
        {
            var automComplete = sender as AutoCompleteBox;
            if (automComplete == null) return;
            var itemWrapper = automComplete.SelectedItem as AutoCompleteBoxVisual.TemplateContentItemWrapper;
            if (itemWrapper == null) return;

            var contact = itemWrapper.Value as Contact;
            if (contact == null) return;

            //do the saving here
            //TODO: Should compare for Id and not the name, but for the sake of simplicity that should do it
            if (contact.Name != "***Add New") return;

            this.Details.Dispatcher.BeginInvoke(() =>
            {
                if (_newContact == null || _newContact.Details.EntityState == EntityState.Modified)
                {
                    //create a new contact and assign it
                    var _newContact = this.DataWorkspace.ApplicationData.Contacts.AddNew();
                    _newContact.Name = "TODO: Your New Name Here";

                    //set it on the current selected matter
                    this.Matters.SelectedItem.Contact = _newContact;
                }
            });




        }

        private void OnContactAutoCompleteOnPopulating(object sender, PopulatingEventArgs e)
        {
            ContactNameFilter = e.Parameter;
        }


 

        #endregion

        partial void MatterListAddAndEditNew_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void MatterListAddAndEditNew_Execute()
        {
            this.Matters.AddNew();

        }
    }
}