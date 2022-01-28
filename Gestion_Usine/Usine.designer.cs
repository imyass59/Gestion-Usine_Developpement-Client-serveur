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
	public partial class UsineDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArticle(articles instance);
    partial void UpdateArticle(articles instance);
    partial void DeleteArticle(articles instance);
    partial void InsertEmploye(Employe instance);
    partial void UpdateEmploye(Employe instance);
    partial void DeleteEmploye(Employe instance);
    partial void Insertwproduction(wproduction instance);
    partial void Updatewproduction(wproduction instance);
    partial void Deletewproduction(wproduction instance);
    #endregion
		
		public UsineDataContext() : 
				base(global::Gestion_Usine.Properties.Settings.Default.UsineConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UsineDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsineDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsineDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsineDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<articles> Articles
		{
			get
			{
				return this.GetTable<articles>();
			}
		}
		
		public System.Data.Linq.Table<Employe> Employes
		{
			get
			{
				return this.GetTable<Employe>();
			}
		}
		
		public System.Data.Linq.Table<Production> Productions
		{
			get
			{
				return this.GetTable<Production>();
			}
		}
		
		public System.Data.Linq.Table<wproduction> wproductions
		{
			get
			{
				return this.GetTable<wproduction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Article")]
	public partial class articles : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _codea;
		
		private string _Designation;
		
		private System.Nullable<double> _Prix;
		
		private System.Nullable<int> _stock;
		
		private EntitySet<wproduction> _wproductions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodeaChanging(int value);
    partial void OncodeaChanged();
    partial void OnDesignationChanging(string value);
    partial void OnDesignationChanged();
    partial void OnPrixChanging(System.Nullable<double> value);
    partial void OnPrixChanged();
    partial void OnstockChanging(System.Nullable<int> value);
    partial void OnstockChanged();
    #endregion
		
		public articles()
		{
			this._wproductions = new EntitySet<wproduction>(new Action<wproduction>(this.attach_wproductions), new Action<wproduction>(this.detach_wproductions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codea", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int codea
		{
			get
			{
				return this._codea;
			}
			set
			{
				if ((this._codea != value))
				{
					this.OncodeaChanging(value);
					this.SendPropertyChanging();
					this._codea = value;
					this.SendPropertyChanged("codea");
					this.OncodeaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Designation", DbType="VarChar(20)")]
		public string Designation
		{
			get
			{
				return this._Designation;
			}
			set
			{
				if ((this._Designation != value))
				{
					this.OnDesignationChanging(value);
					this.SendPropertyChanging();
					this._Designation = value;
					this.SendPropertyChanged("Designation");
					this.OnDesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prix", DbType="Float")]
		public System.Nullable<double> Prix
		{
			get
			{
				return this._Prix;
			}
			set
			{
				if ((this._Prix != value))
				{
					this.OnPrixChanging(value);
					this.SendPropertyChanging();
					this._Prix = value;
					this.SendPropertyChanged("Prix");
					this.OnPrixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock", DbType="Int")]
		public System.Nullable<int> stock
		{
			get
			{
				return this._stock;
			}
			set
			{
				if ((this._stock != value))
				{
					this.OnstockChanging(value);
					this.SendPropertyChanging();
					this._stock = value;
					this.SendPropertyChanged("stock");
					this.OnstockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_wproduction", Storage="_wproductions", ThisKey="codea", OtherKey="codea")]
		public EntitySet<wproduction> wproductions
		{
			get
			{
				return this._wproductions;
			}
			set
			{
				this._wproductions.Assign(value);
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
		
		private void attach_wproductions(wproduction entity)
		{
			this.SendPropertyChanging();
			entity.Article = this;
		}
		
		private void detach_wproductions(wproduction entity)
		{
			this.SendPropertyChanging();
			entity.Article = null;
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
		
		private EntitySet<wproduction> _wproductions;
		
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
			this._wproductions = new EntitySet<wproduction>(new Action<wproduction>(this.attach_wproductions), new Action<wproduction>(this.detach_wproductions));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employe_wproduction", Storage="_wproductions", ThisKey="Mat", OtherKey="Mat")]
		public EntitySet<wproduction> wproductions
		{
			get
			{
				return this._wproductions;
			}
			set
			{
				this._wproductions.Assign(value);
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
		
		private void attach_wproductions(wproduction entity)
		{
			this.SendPropertyChanging();
			entity.Employe = this;
		}
		
		private void detach_wproductions(wproduction entity)
		{
			this.SendPropertyChanging();
			entity.Employe = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Production")]
	public partial class Production
	{
		
		private System.Nullable<int> _Num;
		
		private System.Nullable<System.DateTime> _DP;
		
		private System.Nullable<int> _Mat;
		
		private System.Nullable<int> _codea;
		
		private System.Nullable<int> _qtitep;
		
		public Production()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num", DbType="Int")]
		public System.Nullable<int> Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this._Num = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DP", DbType="Date")]
		public System.Nullable<System.DateTime> DP
		{
			get
			{
				return this._DP;
			}
			set
			{
				if ((this._DP != value))
				{
					this._DP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mat", DbType="Int")]
		public System.Nullable<int> Mat
		{
			get
			{
				return this._Mat;
			}
			set
			{
				if ((this._Mat != value))
				{
					this._Mat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codea", DbType="Int")]
		public System.Nullable<int> codea
		{
			get
			{
				return this._codea;
			}
			set
			{
				if ((this._codea != value))
				{
					this._codea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qtitep", DbType="Int")]
		public System.Nullable<int> qtitep
		{
			get
			{
				return this._qtitep;
			}
			set
			{
				if ((this._qtitep != value))
				{
					this._qtitep = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.wproduction")]
	public partial class wproduction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Num;
		
		private System.Nullable<System.DateTime> _DP;
		
		private System.Nullable<int> _Mat;
		
		private string _NP;
		
		private System.Nullable<int> _codea;
		
		private string _Designation;
		
		private System.Nullable<int> _qp;
		
		private EntityRef<articles> _Article;
		
		private EntityRef<Employe> _Employe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumChanging(int value);
    partial void OnNumChanged();
    partial void OnDPChanging(System.Nullable<System.DateTime> value);
    partial void OnDPChanged();
    partial void OnMatChanging(System.Nullable<int> value);
    partial void OnMatChanged();
    partial void OnNPChanging(string value);
    partial void OnNPChanged();
    partial void OncodeaChanging(System.Nullable<int> value);
    partial void OncodeaChanged();
    partial void OnDesignationChanging(string value);
    partial void OnDesignationChanged();
    partial void OnqpChanging(System.Nullable<int> value);
    partial void OnqpChanged();
    #endregion
		
		public wproduction()
		{
			this._Article = default(EntityRef<articles>);
			this._Employe = default(EntityRef<Employe>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Num
		{
			get
			{
				return this._Num;
			}
			set
			{
				if ((this._Num != value))
				{
					this.OnNumChanging(value);
					this.SendPropertyChanging();
					this._Num = value;
					this.SendPropertyChanged("Num");
					this.OnNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DP", DbType="Date")]
		public System.Nullable<System.DateTime> DP
		{
			get
			{
				return this._DP;
			}
			set
			{
				if ((this._DP != value))
				{
					this.OnDPChanging(value);
					this.SendPropertyChanging();
					this._DP = value;
					this.SendPropertyChanged("DP");
					this.OnDPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mat", DbType="Int")]
		public System.Nullable<int> Mat
		{
			get
			{
				return this._Mat;
			}
			set
			{
				if ((this._Mat != value))
				{
					if (this._Employe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMatChanging(value);
					this.SendPropertyChanging();
					this._Mat = value;
					this.SendPropertyChanged("Mat");
					this.OnMatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NP", DbType="VarChar(50)")]
		public string NP
		{
			get
			{
				return this._NP;
			}
			set
			{
				if ((this._NP != value))
				{
					this.OnNPChanging(value);
					this.SendPropertyChanging();
					this._NP = value;
					this.SendPropertyChanged("NP");
					this.OnNPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codea", DbType="Int")]
		public System.Nullable<int> codea
		{
			get
			{
				return this._codea;
			}
			set
			{
				if ((this._codea != value))
				{
					if (this._Article.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncodeaChanging(value);
					this.SendPropertyChanging();
					this._codea = value;
					this.SendPropertyChanged("codea");
					this.OncodeaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Designation", DbType="VarChar(20)")]
		public string Designation
		{
			get
			{
				return this._Designation;
			}
			set
			{
				if ((this._Designation != value))
				{
					this.OnDesignationChanging(value);
					this.SendPropertyChanging();
					this._Designation = value;
					this.SendPropertyChanged("Designation");
					this.OnDesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qp", DbType="Int")]
		public System.Nullable<int> qp
		{
			get
			{
				return this._qp;
			}
			set
			{
				if ((this._qp != value))
				{
					this.OnqpChanging(value);
					this.SendPropertyChanging();
					this._qp = value;
					this.SendPropertyChanged("qp");
					this.OnqpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_wproduction", Storage="_Article", ThisKey="codea", OtherKey="codea", IsForeignKey=true)]
		public articles Article
		{
			get
			{
				return this._Article.Entity;
			}
			set
			{
				articles previousValue = this._Article.Entity;
				if (((previousValue != value) 
							|| (this._Article.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article.Entity = null;
						previousValue.wproductions.Remove(this);
					}
					this._Article.Entity = value;
					if ((value != null))
					{
						value.wproductions.Add(this);
						this._codea = value.codea;
					}
					else
					{
						this._codea = default(Nullable<int>);
					}
					this.SendPropertyChanged("Article");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employe_wproduction", Storage="_Employe", ThisKey="Mat", OtherKey="Mat", IsForeignKey=true)]
		public Employe Employe
		{
			get
			{
				return this._Employe.Entity;
			}
			set
			{
				Employe previousValue = this._Employe.Entity;
				if (((previousValue != value) 
							|| (this._Employe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employe.Entity = null;
						previousValue.wproductions.Remove(this);
					}
					this._Employe.Entity = value;
					if ((value != null))
					{
						value.wproductions.Add(this);
						this._Mat = value.Mat;
					}
					else
					{
						this._Mat = default(Nullable<int>);
					}
					this.SendPropertyChanged("Employe");
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