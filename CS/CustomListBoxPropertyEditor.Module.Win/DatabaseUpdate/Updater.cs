using CustomListBoxPropertyEditor.Module.Win.Editors;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomListBoxPropertyEditor.Module.Win.DatabaseUpdate {
    // Allows you to handle a database update when the application version changes (http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic help article for more details).
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion)
        {
        }
        // Override to specify the database update code which should be performed after the database schema is updated (http://documentation.devexpress.com/#Xaf/DevExpressExpressAppUpdatingModuleUpdater_UpdateDatabaseAfterUpdateSchematopic).
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();
            Position Customer = ObjectSpace.FindObject<Position>(new BinaryOperator("Title", "Customer", BinaryOperatorType.Equal));
            if(Customer == null) {
                Customer = ObjectSpace.CreateObject<Position>();
                Customer.Title = "Customer";
            }
            Position HR = ObjectSpace.FindObject<Position>(new BinaryOperator("Title", "HR", BinaryOperatorType.Equal));
            if(HR == null) {
                HR = ObjectSpace.CreateObject<Position>();
                HR.Title = "HR";
            }
            Position Manager = ObjectSpace.FindObject<Position>(new BinaryOperator("Title", "Manager", BinaryOperatorType.Equal));
            if(Manager == null) {
                Manager = ObjectSpace.CreateObject<Position>();
                Manager.Title = "Manager";
            }
            Contact AlexSmith = ObjectSpace.FindObject<Contact>(new BinaryOperator("FirstName", "Alex", BinaryOperatorType.Equal));
            if(AlexSmith == null) {
                AlexSmith = ObjectSpace.CreateObject<Contact>();
                AlexSmith.FirstName = "Alex";
                AlexSmith.LastName = "Smith";
                AlexSmith.Position = Manager;
                AlexSmith.TitleOfCourtesy = TitleOfCourtesy.Mr;
            }
           
        }

    
    }
}

