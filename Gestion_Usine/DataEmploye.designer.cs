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

namespace Gestion_Usine
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Usine")]
	public partial class DataEmployeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmploye(Employe instance);
    partial void UpdateEmploye(Employe instance);
    partial void DeleteEmploye(Employe instance);
    #endregion
		
		public DataEmployeDataContext() : 
				base(global::Gestion_Usine.Properties.Settings.Default.UsineConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmployeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employe> Employes
		{
			get
			{
				return this.GetTable<Employe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employe")]
	public partial class Employe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Mat;
		
		private string _Nom;
		
		private string _Prenom;
		
		private System.Nullable<System.DateTime> _DN;
		
		private string _Adresse;
		
		private string _Tel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMatChanging(int value);
    partial void OnMatChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnDNChanging(System.Nullable<System.DateTime> value);
    partial void OnDNChanged();
    partial void OnAdresseChanging(string value);
    partial void OnAdresseChanged();
    partial void OnTelChanging(string value);
    partial void OnTelChanged();
    #endregion
		
		public Employe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mat", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Mat
		{
			get
			{
				return this._Mat;
			}
			set
			{
				if ((this._Mat != value))
				{
					this.OnMatChanging(value);
					this.SendPropertyChanging();
					this._Mat = value;
					this.SendPropertyChanged("Mat");
					this.OnMatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(20)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="VarChar(20)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DN", DbType="Date")]
		public System.Nullable<System.DateTime> DN
		{
			get
			{
				return this._DN;
			}
			set
			{
				if ((this._DN != value))
				{
					this.OnDNChanging(value);
					this.SendPropertyChanging();
					this._DN = value;
					this.SendPropertyChanged("DN");
					this.OnDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresse", DbType="VarChar(20)")]
		public string Adresse
		{
			get
			{
				return this._Adresse;
			}
			set
			{
				if ((this._Adresse != value))
				{
					this.OnAdresseChanging(value);
					this.SendPropertyChanging();
					this._Adresse = value;
					this.SendPropertyChanged("Adresse");
					this.OnAdresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tel", DbType="VarChar(20)")]
		public string Tel
		{
			get
			{
				return this._Tel;
			}
			set
			{
				if ((this._Tel != value))
				{
					this.OnTelChanging(value);
					this.SendPropertyChanging();
					this._Tel = value;
					this.SendPropertyChanged("Tel");
					this.OnTelChanged();
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