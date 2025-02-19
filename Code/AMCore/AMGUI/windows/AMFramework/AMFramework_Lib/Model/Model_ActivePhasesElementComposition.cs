﻿using AMFramework_Lib.AMSystem.Attributes;

namespace AMFramework_Lib.Model
{
    public class Model_ActivePhasesElementComposition : ModelAbstract
    {
        private int _id = -1;
        [Order]
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        private int _idProject = -1;
        [Order]
        public int IDProject
        {
            get { return _idProject; }
            set
            {
                _idProject = value;
                OnPropertyChanged(nameof(IDProject));
            }
        }

        private int _idElement = -1;
        [Order]
        public int IDElement
        {
            get { return _idElement; }
            set
            {
                _idElement = value;
                OnPropertyChanged(nameof(IDElement));
            }
        }

        private double _value = -1;
        [Order]
        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        #region Other
        private string _elementName = "";
        public string ElementName
        {
            get { return _elementName; }
            set
            {
                _elementName = value;
                OnPropertyChanged(nameof(ElementName));
            }
        }

        private bool _isReferenceElement = false;
        public bool IsReferenceElement
        {
            get { return _isReferenceElement; }
            set
            {
                _isReferenceElement = value;
                OnPropertyChanged(nameof(IsReferenceElement));
            }
        }
        #endregion

        #region Interfaces
        public override IOrderedEnumerable<System.Reflection.PropertyInfo> Get_parameter_list()
        {
            return ModelAbstract.Get_parameters<Model_ActivePhasesElementComposition>();
        }

        public override string Get_Table_Name()
        {
            return "ActivePhases_ElementComposition";
        }

        public override string Get_Scripting_ClassName()
        {
            return "ActivePhasesElementComposition";
        }
        #endregion
    }
}
