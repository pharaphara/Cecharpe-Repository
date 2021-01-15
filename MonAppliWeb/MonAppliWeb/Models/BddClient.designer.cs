﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonAppliWeb.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bddEQL")]
	public partial class BddClientDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    partial void Insertregion(region instance);
    partial void Updateregion(region instance);
    partial void Deleteregion(region instance);
    #endregion
		
		public BddClientDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bddEQLConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BddClientDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BddClientDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BddClientDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BddClientDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<client> client
		{
			get
			{
				return this.GetTable<client>();
			}
		}
		
		public System.Data.Linq.Table<region> region
		{
			get
			{
				return this.GetTable<region>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.client")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _noclient;
		
		private string _nom;
		
		private string _adresse;
		
		private System.Nullable<int> _noregion;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnoclientChanging(int value);
    partial void OnnoclientChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnadresseChanging(string value);
    partial void OnadresseChanged();
    partial void OnnoregionChanging(System.Nullable<int> value);
    partial void OnnoregionChanged();
    #endregion
		
		public client()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noclient", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int noclient
		{
			get
			{
				return this._noclient;
			}
			set
			{
				if ((this._noclient != value))
				{
					this.OnnoclientChanging(value);
					this.SendPropertyChanging();
					this._noclient = value;
					this.SendPropertyChanged("noclient");
					this.OnnoclientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="NVarChar(50)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse", DbType="NVarChar(50)")]
		public string adresse
		{
			get
			{
				return this._adresse;
			}
			set
			{
				if ((this._adresse != value))
				{
					this.OnadresseChanging(value);
					this.SendPropertyChanging();
					this._adresse = value;
					this.SendPropertyChanged("adresse");
					this.OnadresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noregion", DbType="Int")]
		public System.Nullable<int> noregion
		{
			get
			{
				return this._noregion;
			}
			set
			{
				if ((this._noregion != value))
				{
					this.OnnoregionChanging(value);
					this.SendPropertyChanging();
					this._noregion = value;
					this.SendPropertyChanged("noregion");
					this.OnnoregionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.region")]
	public partial class region : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idregion;
		
		private string _nomregion;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidregionChanging(int value);
    partial void OnidregionChanged();
    partial void OnnomregionChanging(string value);
    partial void OnnomregionChanged();
    #endregion
		
		public region()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idregion", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idregion
		{
			get
			{
				return this._idregion;
			}
			set
			{
				if ((this._idregion != value))
				{
					this.OnidregionChanging(value);
					this.SendPropertyChanging();
					this._idregion = value;
					this.SendPropertyChanged("idregion");
					this.OnidregionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomregion", DbType="NVarChar(50)")]
		public string nomregion
		{
			get
			{
				return this._nomregion;
			}
			set
			{
				if ((this._nomregion != value))
				{
					this.OnnomregionChanging(value);
					this.SendPropertyChanging();
					this._nomregion = value;
					this.SendPropertyChanged("nomregion");
					this.OnnomregionChanged();
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