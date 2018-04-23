using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace CustomListBoxPropertyEditor.Module.Win.Editors {
    [DefaultClassOptions]
    public class Contact : BaseObject {
        private TitleOfCourtesy titleOfCourtesy;
        public Contact(Session session) : base(session) { }
                                                           
        public TitleOfCourtesy TitleOfCourtesy {
            get { return titleOfCourtesy; }
            set { SetPropertyValue("TitleOfCourtesy", ref titleOfCourtesy, value); }
        }
        private string firstName;
        public string FirstName {
            get { return firstName; }
            set { SetPropertyValue("FirstName", ref firstName, value); }
        }
        private string lastName;
        public string LastName {
            get { return lastName; }
            set { SetPropertyValue("LastName", ref lastName, value); }
        }
        private Position position;
        [ImmediatePostDataAttribute]
        public Position Position {
            get { return position; }
            set { SetPropertyValue("Position", ref position, value); }
        }
    }
    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };

    public class Position : BaseObject {

        public Position(Session session) : base(session) { }
        private string title;
        public string Title {
            get { return title; }
            set { SetPropertyValue("Title", ref title, value); }
        }
    }
}

