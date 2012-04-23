﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MobileStore.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MobileDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MobileDbEntities object using the connection string found in the 'MobileDbEntities' section of the application configuration file.
        /// </summary>
        public MobileDbEntities() : base("name=MobileDbEntities", "MobileDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MobileDbEntities object.
        /// </summary>
        public MobileDbEntities(string connectionString) : base(connectionString, "MobileDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MobileDbEntities object.
        /// </summary>
        public MobileDbEntities(EntityConnection connection) : base(connection, "MobileDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Manufacturer> Manufacturers
        {
            get
            {
                if ((_Manufacturers == null))
                {
                    _Manufacturers = base.CreateObjectSet<Manufacturer>("Manufacturers");
                }
                return _Manufacturers;
            }
        }
        private ObjectSet<Manufacturer> _Manufacturers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Manufacturers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToManufacturers(Manufacturer manufacturer)
        {
            base.AddObject("Manufacturers", manufacturer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MobileDbModel", Name="Manufacturer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Manufacturer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Manufacturer object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static Manufacturer CreateManufacturer(global::System.Int32 id)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ID = id;
            return manufacturer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion
    
    }

    #endregion
    
}