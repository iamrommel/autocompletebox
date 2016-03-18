using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Contacts_Updating(Contact entity)
        {
            //do not let this to be updated
            if (entity.Name == "***Add New")
                entity.Details.DiscardChanges();

        }
    }
}