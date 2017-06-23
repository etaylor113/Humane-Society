﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSociety
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="master")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdopter(Adopter instance);
    partial void UpdateAdopter(Adopter instance);
    partial void DeleteAdopter(Adopter instance);
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HumaneSociety.Properties.Settings.Default.masterConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Adopter> Adopters
		{
			get
			{
				return this.GetTable<Adopter>();
			}
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adopter")]
	public partial class Adopter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _User_Address;
		
		private System.Nullable<int> _Contact_Number;
		
		private string _Pet_Preference;
		
		private string _User_Bio;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnUser_AddressChanging(string value);
    partial void OnUser_AddressChanged();
    partial void OnContact_NumberChanging(System.Nullable<int> value);
    partial void OnContact_NumberChanged();
    partial void OnPet_PreferenceChanging(string value);
    partial void OnPet_PreferenceChanged();
    partial void OnUser_BioChanging(string value);
    partial void OnUser_BioChanged();
    #endregion
		
		public Adopter()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string User_Address
		{
			get
			{
				return this._User_Address;
			}
			set
			{
				if ((this._User_Address != value))
				{
					this.OnUser_AddressChanging(value);
					this.SendPropertyChanging();
					this._User_Address = value;
					this.SendPropertyChanged("User_Address");
					this.OnUser_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact_Number", DbType="Int")]
		public System.Nullable<int> Contact_Number
		{
			get
			{
				return this._Contact_Number;
			}
			set
			{
				if ((this._Contact_Number != value))
				{
					this.OnContact_NumberChanging(value);
					this.SendPropertyChanging();
					this._Contact_Number = value;
					this.SendPropertyChanged("Contact_Number");
					this.OnContact_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Preference", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pet_Preference
		{
			get
			{
				return this._Pet_Preference;
			}
			set
			{
				if ((this._Pet_Preference != value))
				{
					this.OnPet_PreferenceChanging(value);
					this.SendPropertyChanging();
					this._Pet_Preference = value;
					this.SendPropertyChanged("Pet_Preference");
					this.OnPet_PreferenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Bio", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string User_Bio
		{
			get
			{
				return this._User_Bio;
			}
			set
			{
				if ((this._User_Bio != value))
				{
					this.OnUser_BioChanging(value);
					this.SendPropertyChanging();
					this._User_Bio = value;
					this.SendPropertyChanged("User_Bio");
					this.OnUser_BioChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animals")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Type_Class;
		
		private string _Type_Order;
		
		private string _Type_Species;
		
		private System.Nullable<int> _Room_Number;
		
		private System.Nullable<bool> _Adoption_Status;
		
		private string _Food_Type;
		
		private System.Nullable<int> _Amount_Food_Week;
		
		private System.Nullable<decimal> _Price;
		
		private string _Personality;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnType_ClassChanging(string value);
    partial void OnType_ClassChanged();
    partial void OnType_OrderChanging(string value);
    partial void OnType_OrderChanged();
    partial void OnType_SpeciesChanging(string value);
    partial void OnType_SpeciesChanged();
    partial void OnRoom_NumberChanging(System.Nullable<int> value);
    partial void OnRoom_NumberChanged();
    partial void OnAdoption_StatusChanging(System.Nullable<bool> value);
    partial void OnAdoption_StatusChanged();
    partial void OnFood_TypeChanging(string value);
    partial void OnFood_TypeChanged();
    partial void OnAmount_Food_WeekChanging(System.Nullable<int> value);
    partial void OnAmount_Food_WeekChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnPersonalityChanging(string value);
    partial void OnPersonalityChanged();
    #endregion
		
		public Animal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type_Class", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type_Class
		{
			get
			{
				return this._Type_Class;
			}
			set
			{
				if ((this._Type_Class != value))
				{
					this.OnType_ClassChanging(value);
					this.SendPropertyChanging();
					this._Type_Class = value;
					this.SendPropertyChanged("Type_Class");
					this.OnType_ClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type_Order", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type_Order
		{
			get
			{
				return this._Type_Order;
			}
			set
			{
				if ((this._Type_Order != value))
				{
					this.OnType_OrderChanging(value);
					this.SendPropertyChanging();
					this._Type_Order = value;
					this.SendPropertyChanged("Type_Order");
					this.OnType_OrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type_Species", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type_Species
		{
			get
			{
				return this._Type_Species;
			}
			set
			{
				if ((this._Type_Species != value))
				{
					this.OnType_SpeciesChanging(value);
					this.SendPropertyChanging();
					this._Type_Species = value;
					this.SendPropertyChanged("Type_Species");
					this.OnType_SpeciesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room_Number", DbType="Int")]
		public System.Nullable<int> Room_Number
		{
			get
			{
				return this._Room_Number;
			}
			set
			{
				if ((this._Room_Number != value))
				{
					this.OnRoom_NumberChanging(value);
					this.SendPropertyChanging();
					this._Room_Number = value;
					this.SendPropertyChanged("Room_Number");
					this.OnRoom_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adoption_Status", DbType="Bit")]
		public System.Nullable<bool> Adoption_Status
		{
			get
			{
				return this._Adoption_Status;
			}
			set
			{
				if ((this._Adoption_Status != value))
				{
					this.OnAdoption_StatusChanging(value);
					this.SendPropertyChanging();
					this._Adoption_Status = value;
					this.SendPropertyChanged("Adoption_Status");
					this.OnAdoption_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Food_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Food_Type
		{
			get
			{
				return this._Food_Type;
			}
			set
			{
				if ((this._Food_Type != value))
				{
					this.OnFood_TypeChanging(value);
					this.SendPropertyChanging();
					this._Food_Type = value;
					this.SendPropertyChanged("Food_Type");
					this.OnFood_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount_Food_Week", DbType="Int")]
		public System.Nullable<int> Amount_Food_Week
		{
			get
			{
				return this._Amount_Food_Week;
			}
			set
			{
				if ((this._Amount_Food_Week != value))
				{
					this.OnAmount_Food_WeekChanging(value);
					this.SendPropertyChanging();
					this._Amount_Food_Week = value;
					this.SendPropertyChanged("Amount_Food_Week");
					this.OnAmount_Food_WeekChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Personality", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Personality
		{
			get
			{
				return this._Personality;
			}
			set
			{
				if ((this._Personality != value))
				{
					this.OnPersonalityChanging(value);
					this.SendPropertyChanging();
					this._Personality = value;
					this.SendPropertyChanged("Personality");
					this.OnPersonalityChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591