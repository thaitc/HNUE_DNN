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

namespace Look_Up.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dnn")]
	public partial class LookUpDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertnguvan_lookup(nguvan_lookup instance);
    partial void Updatenguvan_lookup(nguvan_lookup instance);
    partial void Deletenguvan_lookup(nguvan_lookup instance);
    #endregion
		
		public LookUpDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LookUpDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LookUpDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LookUpDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LookUpDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<nguvan_lookup> nguvan_lookups
		{
			get
			{
				return this.GetTable<nguvan_lookup>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.nguvan_lookup")]
	public partial class nguvan_lookup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Title;
		
		private string _Instructor;
		
		private string _Author;
		
		private string _Year;
		
		private string _Keys;
		
		private string _Origin;
		
		private string _LibraryID;
		
		private System.Nullable<int> _TabID;
		
		private string _Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnInstructorChanging(string value);
    partial void OnInstructorChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnYearChanging(string value);
    partial void OnYearChanged();
    partial void OnKeysChanging(string value);
    partial void OnKeysChanged();
    partial void OnOriginChanging(string value);
    partial void OnOriginChanged();
    partial void OnLibraryIDChanging(string value);
    partial void OnLibraryIDChanged();
    partial void OnTabIDChanging(System.Nullable<int> value);
    partial void OnTabIDChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public nguvan_lookup()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(MAX)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instructor", DbType="NVarChar(50)")]
		public string Instructor
		{
			get
			{
				return this._Instructor;
			}
			set
			{
				if ((this._Instructor != value))
				{
					this.OnInstructorChanging(value);
					this.SendPropertyChanging();
					this._Instructor = value;
					this.SendPropertyChanged("Instructor");
					this.OnInstructorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(50)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NChar(10)")]
		public string Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Keys", DbType="NVarChar(50)")]
		public string Keys
		{
			get
			{
				return this._Keys;
			}
			set
			{
				if ((this._Keys != value))
				{
					this.OnKeysChanging(value);
					this.SendPropertyChanging();
					this._Keys = value;
					this.SendPropertyChanged("Keys");
					this.OnKeysChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origin", DbType="NVarChar(50)")]
		public string Origin
		{
			get
			{
				return this._Origin;
			}
			set
			{
				if ((this._Origin != value))
				{
					this.OnOriginChanging(value);
					this.SendPropertyChanging();
					this._Origin = value;
					this.SendPropertyChanged("Origin");
					this.OnOriginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibraryID", DbType="NChar(20)")]
		public string LibraryID
		{
			get
			{
				return this._LibraryID;
			}
			set
			{
				if ((this._LibraryID != value))
				{
					this.OnLibraryIDChanging(value);
					this.SendPropertyChanging();
					this._LibraryID = value;
					this.SendPropertyChanged("LibraryID");
					this.OnLibraryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TabID", DbType="Int")]
		public System.Nullable<int> TabID
		{
			get
			{
				return this._TabID;
			}
			set
			{
				if ((this._TabID != value))
				{
					this.OnTabIDChanging(value);
					this.SendPropertyChanging();
					this._TabID = value;
					this.SendPropertyChanged("TabID");
					this.OnTabIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
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